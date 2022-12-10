using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TP_DISEÑO.DTO
{
    internal class ResultadoCuestionarioDTO
    {
        public ResultadoCuestionarioDTO()
        {
            this.Errores = new List<int>();
        }
        public List<int> Errores { get; set; }
        public int idCuestionario { get; set; }
    }
}