using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DTO
{
    class PuestoBuscadoDTO
    {
        public PuestoBuscadoDTO()
        {
            this.nombreCompetencias = new List<string>();
            this.puntajesM = new List<int>();
        }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public string nombreEmpresa { get; set; }
        public List<string> nombreCompetencias { get; set; }
        public List<int> puntajesM { get; set; }
    }
}
