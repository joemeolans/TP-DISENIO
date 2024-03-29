﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO.DAO;
using TP_DISEÑO.DTO;

namespace TP_DISEÑO.Gestores
{
    class GestorPuesto
    {
        public DAO.CompetenciaDAOImpl competenciaDAO;
        public DAO.EmpresaDAOImpl empresaDAO;
        public DAO.PuestoBuscadoDAOImpl puestoBuscadoDAO;

        public GestorPuesto()
        {
            this.empresaDAO = new DAO.EmpresaDAOImpl();
            this.competenciaDAO = new DAO.CompetenciaDAOImpl();
            this.puestoBuscadoDAO = new DAO.PuestoBuscadoDAOImpl();
        }
        public List<int> validarNuevoPuesto(DTO.PuestoBuscadoDTO pbDTO, CapitalHumano3Entities context)
        {
            List<int> errores = new List<int>();

            // CODIGO DE VALIDACION.

            // nombre debe ser un string de longitud aceptable.
            if (!(pbDTO.nombre is string) || pbDTO.nombre.Length <= 0)
            {
                errores.Add(1); // ERROR 1: nombre del puesto es invalido.

            }

            // descricpcion debe ser un string de longitud aceptable.
            if (!(pbDTO.descripcion is string) || pbDTO.descripcion.Length <= 0)
            {
                errores.Add(2);// ERROR 2: descripcion es invalido.
            }

            // nombre empresa ser un string de longitud aceptable y corresponderse con una empresa de la bdd.
            if (!(pbDTO.nombreEmpresa is string) || pbDTO.nombreEmpresa.Length <= 0 || pbDTO.nombreEmpresa.Length > 20)
            {
                errores.Add(3); // ERROR 3: nombre empresa es inválido.
            }
            else
            {
                if (empresaDAO.GetEmpresaByNombre(pbDTO.nombreEmpresa, context) is null)
                {
                    errores.Add(4); // ERROR 4: no existe la empresa especificada.
                }
                else
                {
                    empresa empresa = empresaDAO.GetEmpresaByNombre(pbDTO.nombreEmpresa, context);
                    foreach (var oPuesto in empresa.puestobuscado)
                    {
                        if (oPuesto.Nombre.ToLower().Equals(pbDTO.nombre.ToLower()) && oPuesto.CodigoPuesto.ToLower().Equals(pbDTO.codigo.ToLower()))
                        {
                            errores.Add(9); // ERROR 9: Ya existe ese nombre y codigo de puesto para la empresa seleccionada
                            break;
                        }
                    }
                }
            }

            // el puntajeminimo debe ser un entero y de un valor aceptable.
            foreach (var oPuntaje in pbDTO.puntajesM)
            {
                if (!(oPuntaje is int) || oPuntaje <= 0 || oPuntaje > 100)
                {
                    errores.Add(5); // ERROR 5: es inválido algún puntaje minimo;
                    break;
                }
            }

            // el nombre competencia debe ser un string de longitud aceptable y corresponderse con una competencia en la bdd.
            foreach (var oNombre in pbDTO.nombreCompetencias)
            {
                if (!(oNombre is string) || oNombre.Length <= 0 || oNombre.Length > 40)
                {
                    errores.Add(6); // ERROR 6: es inválido el nombre de alguna competencia.
                    break;
                }
                else
                {
                    if (competenciaDAO.GetCompetenciaByNombre(oNombre, context) is null)
                    {
                        errores.Add(7); // ERROR 7: no existe alguna de las competencias seleccionadas.
                        break;
                    }
                }
            }

            // Deben ser "pares ordenados" los nombres de las competencias y de los puntajes.
            if (pbDTO.nombreCompetencias.Count() != pbDTO.puntajesM.Count())
            {
                errores.Add(8); // ERROR 8: no hay misma cantidad de puntajes minimos que de competencias.
            }

            // Codigo del puesto vacio o nulo
            if (!(pbDTO.codigo is string) || pbDTO.codigo.Length <= 0)
            {
                errores.Add(11); // ERROR 11: codigo del puesto es invalido.

            }

            // Valida que no exista el codigo y/o nombre ingresado para el puesto en la empresa ingresada 
            foreach (string nombre in pbDTO.nombreCompetencias)
            {
                bool exitloop = false;
                int apariciones = 0;
                foreach (string repetido in pbDTO.nombreCompetencias)
                {
                    if (repetido == nombre)
                    {
                        apariciones++;
                    }
                    if (apariciones > 1)
                    {
                        errores.Add(12); // ERROR 12: hay competencias repetidas.
                        exitloop = true;
                        break;
                    }
                }
                if (exitloop)
                {
                    break;
                }
            }

            // Nombre del puesto con logitud mayor a 50
            if (pbDTO.nombre.Length > 50)
            {
                errores.Add(13); // ERROR 13: nombre del puesto con logitud mayor a 50.
            }

            // Codigo del puesto con logitud mayor a 10
            if (pbDTO.codigo.Length > 10)
            {
                errores.Add(14); // ERROR 14: codigo del puesto con logitud mayor a 10.
            }

            // Descripcion con logitud mayor a 150
            if (pbDTO.descripcion.Length > 150)
            {
                errores.Add(15);// ERROR 15: descripcion con logitud mayor a 150 caracteres.
            }

            return errores;
        }

        public List<string> GetAllEmpresas()
        {
            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                return this.empresaDAO.GetAllEmpresas(context);
            }
        }
        public List<string> GetAllCompetencias()
        {
            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                return this.competenciaDAO.GetAllCompetencias(context);
            }
        }
        public void addCompetencia(
            puestobuscado puesto, string nombreCompetencia, int puntajeminimo, DAO.ICompetenciaDAO comDAO, CapitalHumano3Entities context)
        {
            puestobuscadocompetencia pbc = new puestobuscadocompetencia();
            pbc.PuntajeMinimo = puntajeminimo;
            pbc.puestobuscado = puesto;
            pbc.competencia = comDAO.GetCompetenciaByNombre(nombreCompetencia, context);
            puesto.puestobuscadocompetencia.Add(pbc);

        }
        public List<int> AltaPuesto(DTO.PuestoBuscadoDTO pbDTO)
        {
            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                List<int> errores = validarNuevoPuesto(pbDTO, context);
                if (errores.Count == 0)
                {
                    puestobuscado puestobuscado = new puestobuscado();
                    puestobuscado.CodigoPuesto = pbDTO.codigo;
                    puestobuscado.Nombre = pbDTO.nombre;
                    puestobuscado.Descripcion = pbDTO.descripcion;
                    // Asignar empresa
                    puestobuscado.empresa = this.empresaDAO.GetEmpresaByNombre(pbDTO.nombreEmpresa, context);
                    // Añadir competencias
                    for (var i = 0; i < pbDTO.nombreCompetencias.Count(); i++)
                    {
                        this.addCompetencia(puestobuscado, pbDTO.nombreCompetencias[i], pbDTO.puntajesM[i], this.competenciaDAO, context);
                    }
                    // Persistirlo a la base de datos
                    this.puestoBuscadoDAO.createPuestoBuscado(puestobuscado, context);
                }
                return errores;
            }
        }
        public List<int> validarBuscaPuesto(DTO.PuestoBuscadoDTO pbDTO, CapitalHumano3Entities context)
        {
            List<int> resultado = new List<int>();

            if(pbDTO.nombre is string)
            {
                if(pbDTO.nombre.Length > 0 && pbDTO.nombre.Length <= 50)
                {
                    resultado.Add(1);
                }
            }
            if(pbDTO.codigo is string)
            {
                if(pbDTO.codigo.Length > 0 && pbDTO.codigo.Length <= 10)
                {
                    resultado.Add(2);
                }
            }
            if(pbDTO.nombreEmpresa is string)
            {
                if(pbDTO.nombreEmpresa.Length > 0 && pbDTO.nombreEmpresa.Length <= 20)
                { 
                    resultado.Add(3);
                    
                }
            }
            return resultado;
        }
        public List<DTO.PuestoBuscadoDTO> BuscarPuesto(DTO.PuestoBuscadoDTO pbDTO)
        {
            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                List<PuestoBuscadoDTO> pDTO = new List<PuestoBuscadoDTO>();
                List<int> parametros = this.validarBuscaPuesto(pbDTO, context);
                if(parametros.Count != 0)
                {
                    List<puestobuscado> puestos = this.puestoBuscadoDAO.GetPuestosBuscados(pbDTO.nombre, pbDTO.codigo, pbDTO.nombreEmpresa, parametros, context);
                    if (puestos.Count() > 0) {
                        foreach (puestobuscado oPuesto in puestos)
                        {
                            DTO.PuestoBuscadoDTO oPuestoBuscadoDTO = new DTO.PuestoBuscadoDTO();
                            oPuestoBuscadoDTO.nombre = oPuesto.Nombre;
                            oPuestoBuscadoDTO.codigo = oPuesto.CodigoPuesto;
                            oPuestoBuscadoDTO.nombreEmpresa = oPuesto.empresa.Nombre;
                            pDTO.Add(oPuestoBuscadoDTO);

                        }
                    }
                }
                return pDTO;
            }
            
        }

        public puestobuscado GetPuestoById(int idPuesto, CapitalHumano3Entities context)
        {
            return this.puestoBuscadoDAO.GetPuestobuscado(idPuesto, context);
        }

        public List<competencia> GetAllCompetencias(int idPuesto, CapitalHumano3Entities context)
        {
            return this.puestoBuscadoDAO.GetAllCompetencias(idPuesto, context);
        }

        public List<string> GetPuestosByEmpresa(string nombreEmpresa)
        {
            List<string> nombrePuestos = new List<string>();
           
            using(CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                List<puestobuscado> puestos = this.puestoBuscadoDAO.GetPuestosByEmpresa(nombreEmpresa, context);

                foreach(var oPuesto in puestos)
                {
                    nombrePuestos.Add(oPuesto.Nombre);
                }
            }
            return nombrePuestos;
        }

        public List<DTO.CompetenciaDTO> GetCompetenciasByEmpresaPuesto(string nombreEmpresa, string nombrePuesto)
        {
            List<DTO.CompetenciaDTO> compDTO = new List<DTO.CompetenciaDTO>();

            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                List<puestobuscadocompetencia> pbCompetencias = this.puestoBuscadoDAO.GetPBCByEmpresaPuesto(nombreEmpresa, nombrePuesto, context);
                foreach(var oCompetencia in pbCompetencias)
                {
                    DTO.CompetenciaDTO oCompetenciaDTO = new DTO.CompetenciaDTO();
                    oCompetenciaDTO.NombreCompetencia = oCompetencia.competencia.NombreCompetencia;
                    oCompetenciaDTO.PonderacionMinima = oCompetencia.PuntajeMinimo;
                    compDTO.Add(oCompetenciaDTO);
                }
            }
            return compDTO;
        }

        public int GetPuestobuscadoByNombreYEmpresa(string nombreEmpresa, string nombrePuesto)
        {
            int idPuesto = 0;
            using(CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                try
                {
                    idPuesto = this.puestoBuscadoDAO.GetPuestobuscadoByNombreYEmpresa(nombreEmpresa, nombrePuesto, context).IdPuesto;
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
            }
            return idPuesto;
            
        }
    }
}
