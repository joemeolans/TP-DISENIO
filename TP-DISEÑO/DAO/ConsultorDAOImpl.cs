using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO.DTO;

namespace TP_DISEÑO.DAO
{
    class ConsultorDAOImpl : IconsultorDAO
    {

        public consultor GetUsuarioByNombre(string nombreUsuarioConsultor, CapitalHumanoEntities context)
        {
            consultor consultor = null;
            try
            {
                consultor = context.consultor.Where(c => c.NombreUsuario == nombreUsuarioConsultor).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return candidato;
        }

        public consultor checkPassword(string contra, CapitalHumanoEntities context)
        {
            if (context.consultor.contraseña = contra)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

    }
}
