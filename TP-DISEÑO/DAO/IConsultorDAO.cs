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

        consultor GetUsuarioByNombre(string nombreUsuarioConsultor, CapitalHumanoEntities context);
        int checkPassword(consultor oConsultor, string contraseña);

    }
}