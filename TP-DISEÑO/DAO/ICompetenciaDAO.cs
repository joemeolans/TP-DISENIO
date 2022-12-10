using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    interface ICompetenciaDAO
    {
        competencia GetCompetencia(int id, CapitalHumano2Entities context);
        competencia GetCompetenciaByNombre(string nombre, CapitalHumano2Entities context);
        List<string> GetAllCompetencias(CapitalHumano2Entities context);
    }
}
