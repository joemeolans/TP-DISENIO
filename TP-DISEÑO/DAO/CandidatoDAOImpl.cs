using System;
using System.Collections.Generic;
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
                candidato = context.candidato.Where(c => c.NumDocumento == numDoc).FirstOrDefault();
                /*
                if(!(candidato.tipodocumento.Tipo == TipoDoc))
                {
                    candidato = null;
                }
                */
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
    }

}
