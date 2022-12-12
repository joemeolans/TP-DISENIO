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
        public List<int> validarUsuario(DTO.UsuarioDTO UDTO, CapitalHumano3Entities context)
        {
            List<int> errores = new List<int>();

            // CODIGO DE VALIDACION.

            // nombreUsuario debe ser un string de longitud aceptable.
            if (!(UDTO.nombreUsuario is string) || UDTO.nombre.Length <= 0)
            {
                errores.Add(1); // ERROR 1: nombre del puesto es invalido.
            }

            // contraseña debe ser un string de longitud aceptable.
            if (!(UDTO.contraseña is string) || UDTO.contraseña.Length <= 0)
            {
                errores.Add(2);// ERROR 2: descripcion es invalido.
            }

            // Nombre del usuario con logitud mayor a 15
            if (UDTO.nombreUsuario.Length > 15)
            {
                errores.Add(3); // ERROR 3: nombre del puesto con logitud mayor a 15.
            }

            // Contraseña del usuario con logitud mayor a 20
            if (UDTO.contraseña.Length > 20)
            {
                errores.Add(4); // ERROR 4: codigo del puesto con logitud mayor a 10.
            }

            // Contraseña nula
            if (UDTO.nombreUsuario.Length == 0)
            {
                errores.Add(5); // ERROR 5: codigo del puesto con logitud mayor a 10.
            }

            // Usuario nulo
            if (UDTO.contraseña.Length == 0)
            {
                errores.Add(6); // ERROR 6: codigo del puesto con logitud mayor a 10.
            }
                
            return errores;
        }

        public DTO.ResultadoCuestionarioDTO realizarCuestionario(DTO.UsuarioDTO UDTO)
        {
            List<int> resultado = new List<int>();

            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {

                resultado = this.validarUsuario(UDTO, context);
                cuestionario resultadoCuestionario = new cuestionario();

                if (resultado.Count == 0)
                {
                    candidato candidato = this.candidatoDAO.GetCandidatoByDoc(UDTO.numDocumento, UDTO.Tipo, context);
                    
                    resultadoCuestionario = this.GetUltimoCuestionarioActivo(candidato, context);
                    if (resultadoCuestionario == null)
                    {
                        resultado.Add(7); //El error numero 7 indica que no existe un usuario para tal cuestionario.
                    }

                }

                ResultadoCuestionarioDTO ResCuestionarioDTO = new ResultadoCuestionarioDTO();
                ResCuestionarioDTO.Errores.Concat(resultado);
                ResCuestionarioDTO.idCuestionario = resultadoCuestionario.IdCuestionario;

                return ResCuestionarioDTO;
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