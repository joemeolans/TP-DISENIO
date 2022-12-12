using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using TP_DISEÑO.DTO;

namespace TP_DISEÑO.Gestores
{
    class GestorConsultor
    {
        public DAO.ConsultorDAOImpl consultorDAO;

        public GestorConsultor()
        {
            this.consultorDAO = new DAO.ConsultorDAOImpl();
        }
        public List<int> validarConsultor(DTO.UsuarioDTO UDTO, CapitalHumano2Entities context)
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
            if (UDTO.nombreUsuario.Length > 20)
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

        public int checkPassword(consultor consultorIngresado)
        {
            UsuarioDTO UDTO = new UsuarioDTO();

            int valor = new int();
            List<String> Contraseñas = this.GetAllContraseñas();

            foreach (var contra in Contraseñas)
            {
                if (consultorIngresado.Contrasenia == contra) //Esta parte no me queda claro
                {
                    valor = 1; //Existe un usuario con tal contraseña.
                }
                else
                {
                    valor = 0; //No existe un usuario con tal contraseña.
                }
            }

            return valor;
        }

        public List<string> GetAllContraseñas()
        {
            using (CapitalHumano2Entities context = new CapitalHumano2Entities())
            {
                return this.consultorDAO.GetAllContraseñas(context);
            }
        }

        public DTO.ResultadoIngresoDTO ingresarUsuario(DTO.UsuarioDTO UDTO)
        {
            List<int> resultadoValidacion = new List<int>();

            using (CapitalHumano2Entities context = new CapitalHumano2Entities())
            {

                resultadoValidacion = this.validarConsultor(UDTO, context);
                int resultadoCheck = new int();
                consultor consultor = new consultor();

                if (resultadoValidacion.Count == 0)
                {
                    consultor = this.consultorDAO.GetUsuarioByNombre(UDTO.nombreUsuario, context);

                    resultadoCheck = this.checkPassword(consultor);
                    if (resultadoCheck == 0)
                    {
                        resultadoValidacion.Add(7); //El error numero 7 indica que la contrasenia ingresada no es la correcta. 
                    }

                }

                ResultadoIngresoDTO ResIngresoDTO = new ResultadoIngresoDTO();
                ResIngresoDTO.Errores.Concat(resultadoValidacion);
                ResIngresoDTO.idConsultor = consultor.IdConsultor;

                return ResIngresoDTO;
            }

        }

    }
}
