using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO.DTO;
using TP_DISEÑO.DAO;

namespace TP_DISEÑO.Gestores
{
    class GestorEvaluacion
    {
        public EvaluacionDAOImpl evaluacionDAO;

        public GestorEvaluacion()
        {
            this.evaluacionDAO = new EvaluacionDAOImpl();
        }

        public void EvaluarCandidato(int idPuesto, List<CandidatoDTO> CandidatoDTO)
        {
            // PREGUNTAS POR BLOQUE
            // PROVISIONAL
            int preguntasXBloque = 2;

            GestorPuesto gestorPuesto = new GestorPuesto();
            GestorCandidato gestorCandidato = new GestorCandidato();

            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                puestobuscado puesto = gestorPuesto.GetPuestoById(idPuesto, context);
                List<competencia> competencias = gestorPuesto.GetAllCompetencias(idPuesto, context);
                evaluacion evaluacion = new evaluacion();
                foreach (CandidatoDTO oCandidatoDTO in CandidatoDTO)
                {
                    List<pregunta> pregCuest = new List<pregunta>();
                    cuestionario cuestionario = new cuestionario();
                    cuestionario.candidato = gestorCandidato.GetCandidatoById(oCandidatoDTO.IdCandidato, context);
                    foreach (var oCompetencia in competencias)
                    {
                        competenciacuestionario compCuest = new competenciacuestionario();
                        compCuest.NombreCompetencia = oCompetencia.NombreCompetencia;
                        List<factor> factores = FiltrarFactores(oCompetencia);
                        foreach (var oFactor in factores)
                        {
                            factorcuestionario factCuest = new factorcuestionario();
                            factCuest.NombreFactor = oFactor.NombreFactor;
                            compCuest.factorcuestionario.Add(factCuest);
                            pregCuest.Concat(GetPreguntasRandom(oFactor));
                        }
                        cuestionario.competenciacuestionario.Add(compCuest);
                    }
                    // Mezclar la lista de preguntas cuestionario
                    var rnd = new Random();
                    List<pregunta> pregCuestMezclada = pregCuest.OrderBy(item => rnd.Next()).ToList();

                    for (int i = 0; i <= Math.Ceiling((double) pregCuestMezclada.Count() / preguntasXBloque); i++)
                    {
                        bloque bloque = new bloque();
                        bloque.NumeroBloque = i;
                        int k = 0;
                        for (int j = 0; j < preguntasXBloque; j++)
                        {
                            preguntacuestionario preguntacuestionario = new preguntacuestionario();
                            preguntacuestionario.TextoPregunta = pregCuestMezclada[k + j].TextoPregunta;
                            List<itemrespuestapregunta> itemsRP = pregCuestMezclada[k+j].itemrespuestapregunta.ToList();

                            foreach (var oItemRP in itemsRP)
                            {
                                respuestacuestionario respCuest = new respuestacuestionario();
                                respCuest.OrdenRespuesta = oItemRP.itemrespuesta.OrdenRespuesta;
                                respCuest.Descripcion = oItemRP.itemrespuesta.Descripcion;
                                respCuest.Ponderacion = oItemRP.PonderacionRespuesta;
                                preguntacuestionario.respuestacuestionario.Add(respCuest);
                                // PASO 43 CDU??
                            }

                            bloque.preguntacuestionario.Add(preguntacuestionario);

                            k += (preguntasXBloque - 1);
                        }
                        cuestionario.bloque.Add(bloque);
                    }
                    evaluacion.cuestionario.Add(cuestionario);
                }

                this.evaluacionDAO.createEvaluacion(evaluacion, context);
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
    }
}