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
        string NUsuario;
        public CDU008(string Usuario)
        {
            NUsuario = Usuario;
            InitializeComponent();
        }

        private void NuevoPuesto_Click(object sender, EventArgs e)
        {
            Form darDeAltaPuesto = new CDU009(NUsuario);
            darDeAltaPuesto.Show();
            this.Hide();
        }

        private void VolverAlMenu_Click(object sender, EventArgs e)
        {
            Form volverAlMenu = new MenuPrincipal(NUsuario);
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

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            if ( (string.IsNullOrWhiteSpace(CodigoDelPuestoInput.Text)) && (string.IsNullOrWhiteSpace(NombreDelPuestoInput.Text)) && (string.IsNullOrWhiteSpace(EmpresaInput.Text)) )
            {
                MessageBox.Show("Debe completar como mínimo un campo.");
            }
            else
            {
                Gestores.GestorPuesto gestorPuesto = new Gestores.GestorPuesto();
                DTO.PuestoBuscadoDTO puestodto = new DTO.PuestoBuscadoDTO();
                puestodto.nombre = NombreDelPuestoInput.Text;
                puestodto.codigo = CodigoDelPuestoInput.Text;
                puestodto.nombreEmpresa = EmpresaInput.Text;
                List <DTO.PuestoBuscadoDTO> puestos = gestorPuesto.BuscarPuesto(puestodto);
                
                dataGridViewCandidatosAEvaluar.Rows.Clear();
                for (int i=0; i<puestos.Count(); i++)
                {
                    Console.WriteLine(puestos[0].nombre);
                    dataGridViewCandidatosAEvaluar.Rows.Add();
                    dataGridViewCandidatosAEvaluar.Rows[i].Cells[0].Value = puestos[i].codigo;
                    dataGridViewCandidatosAEvaluar.Rows[i].Cells[1].Value = puestos[i].nombre;
                    dataGridViewCandidatosAEvaluar.Rows[i].Cells[2].Value = puestos[i].nombreEmpresa;
                }
            }
        }

    }
}
