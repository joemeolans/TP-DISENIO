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

            try
            {
                foreach(int oParametro in parametros)
                {
                    switch (oParametro)
                    {
                        case 1:
                            puestos.Concat(context.puestobuscado.Where(p => p.Nombre == nombre).ToList());
                            break;
                        case 2:
                            puestos.Concat(context.puestobuscado.Where(p => p.CodigoPuesto == codigo).ToList());
                            break;
                        case 3:
                            puestos.Concat(context.empresa.Where(e => e.Nombre == nombreEmpresa).SelectMany(p => p.puestobuscado).ToList());
                            break;
                    }
                }
                puestos.Distinct().ToList();
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
            return puestos;
        }
        public puestobuscado GetPuestobuscado(int idPuesto, CapitalHumano2Entities context)
        {
            puestobuscado puestobuscado = new puestobuscado();
            try
            {
                puestobuscado = context.puestobuscado.Find(idPuesto);
            }
            catch
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return puestobuscado;
        }
        public List<competencia> GetAllCompetencias(int idPuesto, CapitalHumano3Entitites context)
        {
            List<competencia> competencias = new List<competencia>();
            try
            {
                puestobuscado puestobuscado = context.puestobuscad.Find(idPuesto);
                foreach(var pbCompetencias in puestobuscado.puestobuscadocompetencia)
                {
                    competencias.Add(puestobuscadocompetencia.competencia);
                }
            }
            catch
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return competencias;
        }
    }
}
