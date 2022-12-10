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

<<<<<<< HEAD
        consultor GetUsuarioByNombre(string nombreUsuarioConsultor, CapitalHumanoEntities context);
        int checkPassword(consultor oConsultor, string contraseña);
=======
        consultor GetUsuarioByNombre(string nombreUsuarioConsultor, CapitalHumano2Entities context);
        consultor checkPassword(string contraseña, CapitalHumano2Entities context);
>>>>>>> ee74cc5a3caf8367d2a53f7affdf4c20d4f99383

    }
}