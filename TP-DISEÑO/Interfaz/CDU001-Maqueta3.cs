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
    public partial class CDU001_Maqueta3 : Form
    {
        public CDU001_Maqueta3()
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
            Form responderCuestionario = new CDU001_Maqueta1();
            responderCuestionario.Show();
            this.Hide();
        }
    }
}
