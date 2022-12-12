using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    interface ICompetenciaDAO
    {
        competencia GetCompetencia(int id, CapitalHumano3Entities context);
        competencia GetCompetenciaByNombre(string nombre, CapitalHumano3Entities context);
        List<string> GetAllCompetencias(CapitalHumano3Entities context);
    }
}
