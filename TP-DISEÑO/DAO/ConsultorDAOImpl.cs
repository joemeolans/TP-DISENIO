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

<<<<<<< HEAD
        public int checkPassword(consultor oconsultor, string contra)
        {
            if (oconsultor.contraseña = contra)
=======
        public consultor checkPassword(string contra, CapitalHumano2Entities context)
        {
            if (context.consultor.Contrasenia = contra)
>>>>>>> ee74cc5a3caf8367d2a53f7affdf4c20d4f99383
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
