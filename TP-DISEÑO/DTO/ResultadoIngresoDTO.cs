using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TP_DISEÑO.DTO
{
    internal class ResultadoIngresoDTO
    {
        public ResultadoIngresoDTO()
        {
            this.Errores = new List<int>();
        }
        public List<int> Errores { get; set; }
        public int idConsultor { get; set; }
    }
}