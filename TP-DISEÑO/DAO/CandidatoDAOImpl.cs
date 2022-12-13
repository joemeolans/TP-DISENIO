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
                if (id != 0 && (nombre.Length == 0) && (apellido.Length == 0))
                {
                    candidato cand = context.candidato.Find(id);
                    if(cand != null)
                    {
                        candidatos.Add(cand);
                    }
                }else if(id != 0 && (nombre.Length > 0) && (apellido.Length == 0)){
                    candidato cand = context.candidato.Find(id);
                    if(cand != null && cand.Nombre.Equals(nombre))
                    {
                        candidatos.Add(cand);
                    }
                }else if(id != 0 && (nombre.Length == 0) && (apellido.Length > 0))
                {
                    candidato cand = context.candidato.Find(id);
                    if(cand != null && cand.Apellido.Equals(apellido))
                    {
                        candidatos.Add(cand);
                    }
                }else if(id != 0 && (nombre.Length > 0) && (apellido.Length > 0))
                {
                    candidato cand = context.candidato.Find(id);
                    if(cand != null && cand.Apellido.Equals(apellido) && cand.Nombre.Equals(nombre))
                    {
                        candidatos.Add(cand);
                    }
                }
                else
                {
                    if((nombre.Length > 0) && (apellido.Length>0))
                    {
                        candidatos.AddRange(context.candidato.Where(c => c.Nombre == nombre && c.Apellido == apellido).ToList());
                    }
                    else if((nombre.Length > 0) && (apellido.Length == 0))
                    {
                        candidatos.AddRange(context.candidato.Where(c => c.Nombre.Contains(nombre)).ToList());
                    }
                    else if((nombre.Length == 0) && (apellido.Length > 0))
                    {
                        candidatos.AddRange(context.candidato.Where(c => c.Apellido.Contains(apellido)).ToList());
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

            return candidatos.Distinct().ToList();
        }
    }

}
