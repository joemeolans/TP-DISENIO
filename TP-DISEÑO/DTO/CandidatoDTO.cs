using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DTO
{
    class CandidatoDTO
    {
        public CandidatoDTO()
        {
            this.idCuestionarios = new List<int>();
        }
        public string Nombre { get; set; }
        public int IdCandidato { get; set; }
        public string Apellido { get; set; }
        public string Contrasenia { get; set; }
        public string NombreUsuario { get; set; }
        public string Tipo { get; set; }
        public int NumDocumento { get; set; }
        public List<int> idCuestionarios;

    }
}
