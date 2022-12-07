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

        public void createPuestoBuscado(puestobuscado puestobuscado, CapitalHumanoEntities context)
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

        public List<puestobuscado> GetPuestosBuscados(string nombre, string codigo, string nombreEmpresa, List<int> parametros, CapitalHumanoEntities context)
        {
            List<puestobuscado> puestos = new List<puestobuscado>();

            try
            {
                foreach(int oParametro in parametros)
                {
                    switch (oParametro)
                    {
                        case 1:
                            puestos.Concat(context.puestobuscado.Where(p => p.NombrePuesto == nombre).ToList());
                            break;
                        case 2:
                            puestos.Concat(context.puestobuscado.Where(p => p.CodigoPuesto == codigo).ToList());
                            break;
                        case 3:
                            puestos.Concat(context.empresa.Where(e => e.NombreEmpresa == nombreEmpresa).SelectMany(p => p.puestobuscado).ToList());
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
    }
}
