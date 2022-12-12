using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO.DAO;
using TP_DISEÑO.DTO;

namespace TP_DISEÑO.Gestores
{
    class GestorCandidato
    {
        public DAO.CandidatoDAOImpl candidatoDAO;

        public GestorCandidato()
        {
            this.candidatoDAO = new DAO.CandidatoDAOImpl();
        }
        public bool validarUsuario(DTO.CandidatoDTO CDTO, CapitalHumano3Entities context)
        {
            bool resultado = false;

            // CODIGO DE VALIDACION.
           
            // contraseña debe ser un string de longitud aceptable.
            if (!(CDTO.Clave is string) || CDTO.Clave.Length <= 0)
            {
                resultado = true;
            }
            // Contraseña del usuario con logitud mayor a 20
            if (CDTO.Clave.Length > 20)
            {
                resultado = true;
            }
            // NumDocumento debe ser un int y mayor a 0
            if(!(CDTO.NumDocumento is int) || CDTO.NumDocumento < 0)
            {
                resultado = true;
            }
            // el Tipo debe ser uno de los tipos posibles
            if( (CDTO.Tipo != "DNI") && (CDTO.Tipo != "Libreta cívica(LC)") && (CDTO.Tipo != "Libreta de enrolamiento(LE)"))
            {
                resultado = true;
            }

            if (!resultado)
            {
                candidato candidato = this.candidatoDAO.GetCandidatoByDoc(CDTO.NumDocumento, CDTO.Tipo, context);
                if (candidato == null)
                {
                    resultado = true;
                }
                else
                {
                    if (candidato.Contrasenia != CDTO.Clave)
                    {
                        resultado = true;
                    }
                }
            }

            return resultado;
        }

        public int realizarCuestionario(DTO.CandidatoDTO CDTO)
        {
            int resultado = 0;

            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                cuestionario resultadoCuestionario = new cuestionario();
                
                candidato candidato = this.candidatoDAO.GetCandidatoByDoc(CDTO.NumDocumento, CDTO.Tipo, context);
                bool validacion = this.validarUsuario(CDTO, context);
                if (validacion)
                {
                    resultado = -1;
                }
                else
                {
                    resultadoCuestionario = this.GetUltimoCuestionarioActivo(candidato, context);
                    if (resultadoCuestionario != null)
                    {
                        resultado = resultadoCuestionario.IdCuestionario;
                    }
                }
                return resultado;
            }

        }

        public cuestionario GetUltimoCuestionarioActivo(candidato candidato, CapitalHumano3Entities context)
        {

            cuestionario cuestionario = null;

            try
            {
                foreach (cuestionario oCuestionario in candidato.cuestionario)
                {
                    if (oCuestionario.estado1.Estado1 == "Activo")
                    {
                        cuestionario = oCuestionario;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return cuestionario;

        }
        public candidato GetCandidatoById(int idCandidato, CapitalHumano3Entities context)
        {
            return this.candidatoDAO.GetCandidatoById(idCandidato, context);
        }

    }
}