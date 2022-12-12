using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    public interface IPuestoBuscadoDAO
    {
        void createPuestoBuscado(puestobuscado puestobuscado, CapitalHumano3Entities context);
        List<puestobuscado> GetPuestosBuscados(string nombre, string codigo, string nombreEmpresa, List<int> parametros, CapitalHumano3Entities context);
        List<competencia> GetAllCompetencias(int idPuesto, CapitalHumano3Entities context);
    }
}
