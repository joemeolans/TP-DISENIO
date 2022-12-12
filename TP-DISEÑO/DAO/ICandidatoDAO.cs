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
        candidato GetCandidatoByDoc(int numDoc, string TipoDoc, CapitalHumano3Entities context);
        List<candidato> GetCandidatos(string nombre, string apellido, int id, List<int> parametros, CapitalHumano3Entities context);
    }

}