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
    public partial class CDU025_Maqueta2 : Form
    {
        public CDU025_Maqueta2()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Form volverAMaqueta1 = new CDU0025_Maqueta1();
            volverAMaqueta1.Show();
            this.Hide();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BotonSig_Click(object sender, EventArgs e)
        {
            Form irAMaqueta3 = new CDU025_Maqueta3();
            irAMaqueta3.Show();
            this.Hide();
        }
    }
}
