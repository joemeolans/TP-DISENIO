using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    class PuestoBuscadoDAOImpl : IPuestoBuscadoDAO
    {

        public void createPuestoBuscado(puestobuscado puestobuscado, CapitalHumano3Entities context)
        {
            try
            {
                context.puestobuscado.Add(puestobuscado);
                // Your code...
                // Could also be before try if you know the exception occurs in SaveChanges

                context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }

        public List<puestobuscado> GetPuestosBuscados(string nombre, string codigo, string nombreEmpresa, List<int> parametros, CapitalHumano3Entities context)
        {
            List<puestobuscado> puestos = new List<puestobuscado>();
            List<puestobuscado> puestos1 = new List<puestobuscado>();
            List<puestobuscado> puestos2 = new List<puestobuscado>();
            List<puestobuscado> resultado = new List<puestobuscado>();

            try
            {
                foreach (int oParametro in parametros)
                {
                    switch (oParametro)
                    {
                        case 1:
                            puestos = context.puestobuscado.Where(p => p.Nombre.Contains(nombre)).ToList();
                            break;
                        case 2:
                            puestos1 = (from p in context.puestobuscado where p.CodigoPuesto == codigo select p).ToList();
                            break;
                        case 3:
                            List<empresa> empresas = context.empresa.Where(e => e.Nombre.Contains(nombreEmpresa)).ToList();
                            foreach(empresa empresa in empresas)
                            {
                                Console.WriteLine(empresa.Nombre);
                                foreach(puestobuscado puesto in empresa.puestobuscado)
                                {
                                    puestos2.Add(puesto);
                                }
                            }    

                            break;
                    }
                }

            
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
            resultado.AddRange(puestos);
            resultado.AddRange(puestos1);
            resultado.AddRange(puestos2);

            return resultado.Distinct().ToList();
        }
        public puestobuscado GetPuestobuscado(int idPuesto, CapitalHumano3Entities context)
        {
            puestobuscado puestobuscado = new puestobuscado();
            try
            {
                puestobuscado = context.puestobuscado.Find(idPuesto);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return puestobuscado;
        }
        public List<competencia> GetAllCompetencias(int idPuesto, CapitalHumano3Entities context)
        {
            List<competencia> competencias = new List<competencia>();
            try
            {
                puestobuscado puestobuscado = context.puestobuscado.Find(idPuesto);
                foreach(var pbCompetencias in puestobuscado.puestobuscadocompetencia)
                {
                    competencias.Add(pbCompetencias.competencia);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return competencias;
        }

        public List<puestobuscado> GetPuestosByEmpresa(string nombreEmpresa, CapitalHumano3Entities context)
        {
            List<puestobuscado> puestos = new List<puestobuscado>();
            try
            {
                empresa empresa = context.empresa.Where(e => e.Nombre == nombreEmpresa).FirstOrDefault();
                foreach(var oPuesto in empresa.puestobuscado)
                {
                    puestos.Add(oPuesto);
                }
            }
             catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return puestos;
        }

        public List<puestobuscadocompetencia> GetPBCByEmpresaPuesto
               (string nombreEmpresa, string nombrePuesto, CapitalHumano3Entities context)
        {
            List<puestobuscadocompetencia> pbc = new List<puestobuscadocompetencia>();
            try
            {
                empresa empresa = context.empresa.Where(e => e.Nombre == nombreEmpresa).FirstOrDefault();
                foreach(var puestobuscado in empresa.puestobuscado)
                {
                    if(puestobuscado.Nombre == nombrePuesto)
                    {
                        foreach(var pbcompetencia in puestobuscado.puestobuscadocompetencia)
                        {
                            pbc.Add(pbcompetencia);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return pbc;
        }

        public puestobuscado GetPuestobuscadoByNombreYEmpresa(string nombreEmpresa, string nombrePuesto, CapitalHumano3Entities context)
        {
            puestobuscado puestobuscado = new puestobuscado();
            try
            {
                puestobuscado = context.puestobuscado.Where(p => p.empresa.Nombre == nombreEmpresa && p.Nombre == nombrePuesto).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return puestobuscado;
        }
    }
}
