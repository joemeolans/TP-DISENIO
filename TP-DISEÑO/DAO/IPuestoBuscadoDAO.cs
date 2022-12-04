using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    public interface IPuestoBuscadoDAO
    {
        void createPuestoBuscado(puestobuscado puestobuscado, CapitalHumanoEntities context);
        List<puestobuscado> GetPuestosBuscados(DTO.PuestoBuscadoDTO, List<int> parametros, CapitalHumanoEntities context);
    }
}
