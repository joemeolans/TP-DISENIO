using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DTO
{
    internal class UsuarioDTO
    {

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public int numDocumento { get; set; }
        public string Tipo { get; set; }

    }
}