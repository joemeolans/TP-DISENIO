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
    public partial class CDU008 : Form
    {
        public CDU008()
        {
            InitializeComponent();
        }

        private void NuevoPuesto_Click(object sender, EventArgs e)
        {
            Form darDeAltaPuesto = new CDU009();
            darDeAltaPuesto.Show();
            this.Hide();
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            Form volverAlMenu = new MenuPrincipal();
            volverAlMenu.Show();
            this.Hide();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
