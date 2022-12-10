using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO.DTO;

namespace TP_DISEÑO.DAO
{
    interface ICandidatoDAO
    {
<<<<<<< HEAD
        candidato GetCandidatoByDoc(int numDoc, string TipoDoc, CapitalHumanoEntities context);
        cuestionario GetUltimoCuestionarioActivo(candidato candidato);
=======
        candidato GetCandidatoByDoc(int numDoc, string TipoDoc, CapitalHumano2Entities context);
        cuestionario GetUltimoCuestionarioActivo(int numDoc, CapitalHumano2Entities context);
>>>>>>> ee74cc5a3caf8367d2a53f7affdf4c20d4f99383
    }

}