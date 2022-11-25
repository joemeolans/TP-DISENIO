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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void GestionarPuestos_Click(object sender, EventArgs e)
        {
            Form gestionarPuestos = new CDU008();
            gestionarPuestos.Show();
            this.Hide();
        }

     
    }
}
