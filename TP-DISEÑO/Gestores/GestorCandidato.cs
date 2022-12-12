using System;
using System.Collections.Generic;
using System.Linq;
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
        public bool validarUsuario(DTO.UsuarioDTO UDTO, CapitalHumano3Entities context)
        {
            bool resultado = false;

            // CODIGO DE VALIDACION.
            // nombreUsuario debe ser un string de longitud aceptable.
            if (!(UDTO.nombreUsuario is string) || UDTO.nombre.Length <= 0)
            {
                resultado = true; // ERROR: nombre del puesto es invalido.
            }

            // contraseña debe ser un string de longitud aceptable.
            if (!(UDTO.contraseña is string) || UDTO.contraseña.Length <= 0)
            {
                resultado = true;// ERROR: descripcion es invalido.
            }

            // Nombre del usuario con logitud mayor a 15
            if (UDTO.nombreUsuario.Length > 15)
            {
                resultado = true; // ERROR: nombre del puesto con logitud mayor a 15.
            }

            // Contraseña del usuario con logitud mayor a 20
            if (UDTO.contraseña.Length > 20)
            {
                resultado = true; // ERROR: codigo del puesto con logitud mayor a 10.
            }

            // Contraseña nula
            if (UDTO.nombreUsuario.Length == 0)
            {
                resultado = true; // ERROR: codigo del puesto con logitud mayor a 10.
            }

            // Usuario nulo
            if (UDTO.contraseña.Length == 0)
            {
                resultado = true; // ERROR: codigo del puesto con logitud mayor a 10.
            }
            if (!resultado)
            {
                candidato candidato = this.candidatoDAO.GetCandidatoByDoc(UDTO.numDocumento, UDTO.Tipo, context);
                if (candidato == null)
                {
                    resultado = true;
                }
                else
                {
                    if (candidato.Contrasenia != UDTO.contraseña)
                    {
                        resultado = true;
                    }
                }
            }

            return resultado;
        }

        public int realizarCuestionario(DTO.UsuarioDTO UDTO)
        {
            int resultado = 0;

            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                cuestionario resultadoCuestionario = new cuestionario();
                
                candidato candidato = this.candidatoDAO.GetCandidatoByDoc(UDTO.numDocumento, UDTO.Tipo, context);
                    
                    resultadoCuestionario = this.GetUltimoCuestionarioActivo(candidato, context);
                    if (resultadoCuestionario != null)
                    {
                    resultado = resultadoCuestionario.IdCuestionario;
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