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

        public consultor GetUsuarioByNombre(string nombreUsuarioConsultor, CapitalHumano2Entities context)
        {
            consultor consultor = null;
            try
            {
                consultor = context.consultor.Where(c => c.Usuario == nombreUsuarioConsultor).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return consultor;
        }

        public int checkPassword(consultor oconsultor, string contra)
        {
            if (oconsultor.Contrasenia == contra)
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
