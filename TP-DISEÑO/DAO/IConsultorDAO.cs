using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO.DTO;

namespace TP_DISEÑO.DAO
{
    interface IconsultorDAO
    {

        consultor GetUsuarioByNombre(string nombreUsuarioConsultor, CapitalHumano2Entities context);
        consultor checkPassword(string contraseña, CapitalHumano2Entities context);

    }
}