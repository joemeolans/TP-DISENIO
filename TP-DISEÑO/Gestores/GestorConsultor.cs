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
        public bool validarConsultor(DTO.ConsultorDTO CDTO, CapitalHumano3Entities context)
        {
            bool resultado = false;

            // CODIGO DE VALIDACION.
            // nombreUsuario debe ser un string de longitud aceptable.
            if (!(CDTO.nombreUsuario is string) || CDTO.nombreUsuario.Length <= 0)
            {
                resultado = true; // ERROR: nombre del puesto es invalido.
            }

            // contraseña debe ser un string de longitud aceptable.
            if (!(CDTO.contraseña is string) || CDTO.contraseña.Length <= 0)
            {
                resultado = true;// ERROR: descripcion es invalido.
            }

            // Nombre del usuario con logitud mayor a 15
            if (CDTO.nombreUsuario.Length > 20)
            {
                resultado = true; // ERROR: nombre del puesto con logitud mayor a 15.
            }

            // Contraseña del usuario con logitud mayor a 20
            if (CDTO.contraseña.Length > 20)
            {
                resultado = true; // ERROR: codigo del puesto con logitud mayor a 10.
            }

            // Contraseña nula
            if (CDTO.nombreUsuario.Length == 0)
            {
                resultado = true; // ERROR: codigo del puesto con logitud mayor a 10.
            }

            // Usuario nulo
            if (CDTO.contraseña.Length == 0)
            {
                resultado = true; // ERROR: codigo del puesto con logitud mayor a 10.
            }

            return resultado;
        }

        public bool checkPassword(DTO.ConsultorDTO CDTO, consultor consultor)
        {
            bool valor = false;
            if (CDTO.contraseña != consultor.Contrasenia) //Esta parte no me queda claro
            {
                valor = true; //Existe un usuario con tal contraseña.
            }

            return valor;
        }

        public bool ingresarUsuario(DTO.ConsultorDTO CDTO)
        {
            bool resultado = false;

            using (CapitalHumano3Entities context = new CapitalHumano3Entities())
            {
                resultado = this.validarConsultor(CDTO, context);
                if (resultado == false)
                {
                    consultor consultor = this.consultorDAO.GetUsuarioByNombre(CDTO.nombreUsuario, context);
                    if (consultor != null) {
                        bool resultadocheck = this.checkPassword(CDTO, consultor);
                        if (resultadocheck == true)
                        {
                            resultado=true; //El error numero 7 indica que la contrasenia ingresada no es la correcta. 
                        }
                    }
                    else
                    {
                        resultado = true;
                    }
                }
                return resultado;
            }

        }

    }
}
