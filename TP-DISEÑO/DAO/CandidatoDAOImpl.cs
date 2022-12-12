using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO;
using TP_DISEÑO.DTO;

namespace TP_DISEÑO.DAO
{
    class CandidatoDAOImpl : ICandidatoDAO
    {
        public candidato GetCandidatoByDoc(int numDoc, string TipoDoc, CapitalHumano3Entities context)
        {
            candidato candidato = null;
            try
            {
                candidato = context.candidato.Where(c => c.NumDocumento == numDoc && c.tipodocumento.Tipo == TipoDoc).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        
            return candidato;
        }
        public candidato GetCandidatoById(int idCandidato, CapitalHumano3Entities context)
        {
            candidato candidato = null;
            try
            {
                candidato = context.candidato.Find(idCandidato);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return candidato;
        }

        public List<candidato> GetCandidatos
            (string nombre, string apellido, int id, List<int> parametros, CapitalHumano3Entities context)
        {
            List<candidato> candidatos = new List<candidato>();

            try
            {
                foreach(int oParametro in parametros)
                {
                    switch (oParametro)
                    {
                        case 1:
                            candidatos.Concat(context.candidato.Where(c => c.Nombre.Contains(nombre)).ToList());
                            break;
                        case 2:
                            candidatos.Concat(context.candidato.Where(c => c.Apellido.Contains(apellido)).ToList());
                            break;
                        case 3:
                            candidatos.Add(context.candidato.Find(id));
                            break;
                    }
                }
                candidatos.Distinct().ToList();
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

            return candidatos;
        }
    }

}
