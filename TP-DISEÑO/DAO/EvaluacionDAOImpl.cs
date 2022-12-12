using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    class EvaluacionDAOImpl : IEvaluacionDAO
    {
        public void createEvaluacion(evaluacion evaluacion, CapitalHumano3Entities context)
        {
            try
            {
                context.evaluacion.Add(evaluacion);
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
    }
}
