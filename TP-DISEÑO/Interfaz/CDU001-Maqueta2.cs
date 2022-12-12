using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_DISEÑO.Interfaz
{
    public partial class CDU001_Maqueta2 : Form
    {
        public CDU001_Maqueta2()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Form volverACDU001Maqueta1 = new CDU001_Maqueta1();
            volverACDU001Maqueta1.Show();
            this.Hide();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if( (string.IsNullOrWhiteSpace(NombreUsuarioInput.Text)) || (string.IsNullOrWhiteSpace(ContraseñaInput.Text)) )
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                Gestores.GestorConsultor gestorConsultor = new Gestores.GestorConsultor();
                DTO.ConsultorDTO consultordto = new DTO.ConsultorDTO();
                consultordto.nombreUsuario = NombreUsuarioInput.Text;
                consultordto.contraseña = ContraseñaInput.Text;
                bool ingreso = gestorConsultor.ingresarUsuario(consultordto);
                if (ingreso == true)
                {
                    MessageBox.Show("El nombre de usuario y/o contraseña son incorrectos.");
                }
                else
                {
                    Form ingresarMenuPrincipal = new MenuPrincipal();
                    ingresarMenuPrincipal.Show();
                    this.Hide();
                }
            }
        }
    }
}
