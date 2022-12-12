using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.DAO
{
    class EmpresaDAOImpl : IEmpresaDAO
    {
        public empresa GetEmpresaByNombre(string nombre, CapitalHumano3Entities context)
        {
            empresa empresa = null;
            try
            {
                empresa = context.empresa.Where(e => e.Nombre == nombre).FirstOrDefault<empresa>();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return empresa;
        }
        public List<string> GetAllEmpresas(CapitalHumano3Entities context)
        {
            List<string> nombresempresas = new List<string>();
            var empresas = context.empresa;
            foreach (empresa oEmpresa in empresas)
            {
                nombresempresas.Add(oEmpresa.Nombre);
            }
            return nombresempresas;
        }
    }
}
