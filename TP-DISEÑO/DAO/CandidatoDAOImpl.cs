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
        public candidato GetCandidatoByDoc(int numDoc, string TipoDoc, CapitalHumano2Entities context)
        {
            candidato candidato = null;
            try
            {
                candidato = context.candidato.Where(c => c.NumDocumento == numDoc & c.Tipo == TipoDoc).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return candidato;
        }

<<<<<<< HEAD
        public cuestionario GetUltimoCuestionarioActivo(candidato candidato)
=======
        public cuestionario GetUltimoCuestionarioActivo(int numDoc, CapitalHumano2Entities context)
>>>>>>> ee74cc5a3caf8367d2a53f7affdf4c20d4f99383
        {

            cuestionario cuestionario = null;

            try
            {
<<<<<<< HEAD
                
                foreach (cuestionario oCuestionario in candidato.cuestionario)
                {
                    if(oCuestionario.Estado == "Activo")
                    {
                        cuestionario = oCuestionario;
                    }
                }
                
=======
                (context.candidato.Where(c => c.NumDocumento == numDoc).FirstOrDefault()).cuestionario.Estado = "Activo";
>>>>>>> ee74cc5a3caf8367d2a53f7affdf4c20d4f99383
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return cuestionario;

        }

    }

}
