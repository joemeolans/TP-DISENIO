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
    public partial class CDU001_Maqueta1 : Form
    {
        public CDU001_Maqueta1()
        {
            InitializeComponent();
        }


        private void IngresarComoUsuarioConsultor_Click(object sender, EventArgs e)
        {
            Form ingresoConsultor = new CDU001_Maqueta2();
            ingresoConsultor.Show();
            this.Hide();
        }

        private void IngresarComoUsuarioConsultorLOGO_Click(object sender, EventArgs e)
        {
            Form ingresoConsultor = new CDU001_Maqueta2();
            ingresoConsultor.Show();
            this.Hide();
        }
    }
}
