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

        public consultor GetUsuarioByNombre(string nombreUsuarioConsultor, CapitalHumano3Entities context)
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

        public List<string> GetAllContraseñas(CapitalHumano2Entities context)
        {
            List<string> nombreContraseñas = new List<string>();
            var consultores = context.consultor; 
            foreach (consultor oConsultor in consultores)
            {
                nombreContraseñas.Add(oConsultor.Contrasenia);
            }
            return nombreContraseñas;
        }

    }
}
