using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    public interface IPuestoBuscadoDAO
    {
        void createPuestoBuscado(puestobuscado puestobuscado, CapitalHumano2Entities context);
        List<puestobuscado> GetPuestosBuscados(string nombre, string codigo, string nombreEmpresa, List<int> parametros, CapitalHumano2Entities context);
    }
}
