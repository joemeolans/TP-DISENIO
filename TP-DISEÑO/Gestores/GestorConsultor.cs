using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_DISEÑO.Gestores
{
    class GestorConsultor
    {
        public DAO.ConsultorDAOImpl consultorDAO;

        public GestorConsultor()
        {
            this.consultorDAO = new DAO.ConsultorDAOImpl();
        }
        public List<int> validarConsultor(DTO.UsuarioDTO UDTO, CapitalHumanoEntities context)
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
    }
}
