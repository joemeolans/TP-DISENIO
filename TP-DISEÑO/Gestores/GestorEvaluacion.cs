using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO.DTO;
using TP_DISEÑO.DAO;
using System.CodeDom;
using System.Data.Entity;

namespace TP_DISEÑO.Gestores
{
    class GestorEvaluacion
    {
        public EvaluacionDAOImpl evaluacionDAO;

        public GestorEvaluacion()
        {
            this.evaluacionDAO = new EvaluacionDAOImpl();
        }

        public int EvaluarCandidato(int idPuesto, string nConsultor, List<CandidatoDTO> CandidatoDTO)
        {
            int preguntasXBloque = 1;

            GestorPuesto gestorPuesto = new GestorPuesto();
            GestorCandidato gestorCandidato = new GestorCandidato();
            GestorConsultor gestorConsultor = new GestorConsultor();

            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {

                puestobuscado puesto = gestorPuesto.GetPuestoById(idPuesto, context);
                List<competencia> competencias = gestorPuesto.GetAllCompetencias(idPuesto, context);
                consultor consultor = gestorConsultor.GetConsultorByNombre(nConsultor, context);
                evaluacion evaluacion = new evaluacion();

                evaluacion.puestobuscado = puesto;
                evaluacion.consultor = consultor;

                foreach (CandidatoDTO oCandidatoDTO in CandidatoDTO)
                {
                    List<pregunta> pregCuest = new List<pregunta>();
                    cuestionario cuestionario = new cuestionario();
                    cuestionario.estado1 = context.estado.Where(e => e.Estado1 == "Activo").FirstOrDefault();
                    cuestionario.estadodeaprobacion1 = context.estadodeaprobacion.Where(e => e.EstadoDeAprobacion1 == "No Aprobado").FirstOrDefault();
                    cuestionario.CantidadAccesos = 0;
                    cuestionario.PlazoParaSerContestado = 10; // días
                    cuestionario.candidato = gestorCandidato.GetCandidatoById(oCandidatoDTO.IdCandidato, context);

                    foreach (var oCompetencia in competencias)
                    {
                        competenciacuestionario compCuest = new competenciacuestionario();
                        compCuest.NombreCompetencia = oCompetencia.NombreCompetencia;
                        List<factor> factores = FiltrarFactores(oCompetencia);
                        if(factores.Count() > 0)
                        {
                            foreach (var oFactor in factores)
                            {
                                factorcuestionario factCuest = new factorcuestionario();
                                factCuest.NombreFactor = oFactor.NombreFactor;
                                compCuest.factorcuestionario.Add(factCuest);
                                pregCuest.AddRange(GetPreguntasRandom(oFactor));
                            }
                            cuestionario.competenciacuestionario.Add(compCuest);
                        }
                        else
                        {
                            break;                        
                        }
                    }
                    if(cuestionario.competenciacuestionario.Count > 0)
                    {
                        var rnd = new Random();
                        List<pregunta> pregCuestMezclada = pregCuest.OrderBy(item => rnd.Next()).ToList();
                       
                        int k = 0;
                        for (int i = 0; i < Math.Ceiling((double)pregCuestMezclada.Count() / preguntasXBloque); i++)
                        {
                            bloque bloque = new bloque();
                            bloque.NumeroBloque = i;

                            for (int j = 0; j < preguntasXBloque; j++)
                            {
                                pregunta iPregunta = pregCuestMezclada[k + j];
                                preguntacuestionario preguntacuestionario = new preguntacuestionario();
                                preguntacuestionario.TextoPregunta = iPregunta.TextoPregunta;
                                // ESTO LO HACEMOS ASÍ PORQUE NO ENCUENTRA UN FACTOR CUESTIONARIO
                                // CON UN WHERE
                                factorcuestionario factCuest = new factorcuestionario();
                                foreach (var oCompetenciaCuest in cuestionario.competenciacuestionario)
                                {
                                    bool exit = false;
                                    foreach (var oFactorCuest in oCompetenciaCuest.factorcuestionario)
                                    {
                                        if(oFactorCuest.NombreFactor == iPregunta.factor.NombreFactor)
                                        {
                                            factCuest = oFactorCuest;
                                            exit = true;
                                            break;
                                        }
                                    }
                                    if (exit)
                                    {
                                        break;
                                    }
                                }
                                List<itemrespuestapregunta> itemsRP = iPregunta.itemrespuestapregunta.ToList();

                                foreach (var oItemRP in itemsRP)
                                {
                                    // Console.WriteLine("ItemsRP: {0}", oItemRP.itemrespuesta.Descripcion);
                                    respuestacuestionario respCuest = new respuestacuestionario();
                                    respCuest.OrdenRespuesta = oItemRP.itemrespuesta.OrdenRespuesta;
                                    respCuest.Descripcion = oItemRP.itemrespuesta.Descripcion;
                                    respCuest.Ponderacion = oItemRP.PonderacionRespuesta;
                                    preguntacuestionario.respuestacuestionario.Add(respCuest);
                                    // PASO 43 CDU??
                                }
                                bloque.preguntacuestionario.Add(preguntacuestionario);
                                factCuest.preguntacuestionario.Add(preguntacuestionario);
                            }
                            k += (preguntasXBloque);
                            cuestionario.bloque.Add(bloque);
                        }
                        evaluacion.cuestionario.Add(cuestionario);
                    }
                    else
                    {
                        return 0;
                    }
                }
                this.evaluacionDAO.createEvaluacion(evaluacion, context);
                return 1;
            }
        }

        public List<factor> FiltrarFactores(competencia competencia)
        {
            List<factor> allFactores = competencia.factor.ToList();
            List<factor> resultado = new List<factor>();
            foreach (var oFactor in allFactores)
            {
                if (oFactor.pregunta.Count() > 1)
                {
                    resultado.Add(oFactor);
                }
            }
            return resultado;
        }

        public List<pregunta> GetPreguntasRandom(factor factor)
        {

            List<pregunta> resultado = new List<pregunta>();
            Random rd = new Random();

            int rand1 = rd.Next(0, factor.pregunta.Count());
            int rand2;

            do
            {
                rand2 = rd.Next(0, factor.pregunta.Count());
            } while (rand2 == rand1);

            List <pregunta> preguntas = factor.pregunta.ToList();

            resultado.Add(preguntas[rand1]);
            resultado.Add(preguntas[rand2]);

            return resultado;
        }

        public List<int> filtrarCandidatos(List<DTO.CandidatoDTO> candidatosDTO)
        {
            List<int> resultado = new List<int>();
            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                foreach(var oCandidatoDTO in candidatosDTO)
                {
                    candidato candidato = context.candidato.Find(oCandidatoDTO.IdCandidato);
                    if(candidato != null)
                    {
                        foreach (var oCuestionario in candidato.cuestionario)
                        {
                            if(oCuestionario.estado1.Estado1 == "Activo")
                            {
                                resultado.Add(oCandidatoDTO.IdCandidato);
                                break;
                            }
                        }
                    }
                }
            }
            return resultado;
        }
    }
}