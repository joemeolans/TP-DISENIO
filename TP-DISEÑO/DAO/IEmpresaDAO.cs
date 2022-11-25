using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    interface IEmpresaDAO
    {
        List<string> GetAllEmpresas(CapitalHumanoEntities context);
        empresa GetEmpresaByNombre(string nombre, CapitalHumanoEntities context);
    }
}
