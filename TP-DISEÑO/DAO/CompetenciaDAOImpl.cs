using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    class CompetenciaDAOImpl : ICompetenciaDAO
    {
        public competencia GetCompetencia(int id, CapitalHumanoEntities context)
        {
            competencia competencia = context.competencia.Find(id);
            //   competencia competencia = context.competencia.Attach(oCompetencia);
            return competencia;
        }
        public competencia GetCompetenciaByNombre(string nombre, CapitalHumanoEntities context)
        {
            competencia competencia = null;
            try
            {
                competencia = context.competencia.Where(c => c.NombreCompetencia == nombre).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return competencia;
        }
        public List<string> GetAllCompetencias(CapitalHumanoEntities context)
        {
            List<string> nombres = new List<string>();
            var competencias = context.competencia;
            foreach (competencia oCompetencia in competencias)
            {
                nombres.Add(oCompetencia.NombreCompetencia);
            }
            return nombres;
        }
    }
}
