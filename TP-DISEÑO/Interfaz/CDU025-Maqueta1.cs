using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_DISEÑO.DTO;

namespace TP_DISEÑO.Interfaz
{
    public partial class CDU0025_Maqueta1 : Form
    {
        public CDU0025_Maqueta1()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
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

        private void BotonSig_Click(object sender, EventArgs e)
        {
            Form irAMaqueta2 = new CDU025_Maqueta2();
            irAMaqueta2.Show();
            this.Hide();
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(ApellidoInput.Text)) && (string.IsNullOrWhiteSpace(NombreInput.Text)) && (string.IsNullOrWhiteSpace(NroCandidatoInput.Text)))
            {
                MessageBox.Show("Debe completar como mínimo un campo.");
            }
            else
            {
                Gestores.GestorCandidato gestorCandidato = new Gestores.GestorCandidato();
                DTO.CandidatoDTO candidatosdto = new DTO.CandidatoDTO();
                candidatosdto.Apellido = ApellidoInput.Text;
                candidatosdto.Nombre = NombreInput.Text;
                candidatosdto.IdCandidato = Int32.Parse(NroCandidatoInput.Text.ToString());
                List<DTO.CandidatoDTO> candidatos = gestorCandidato.filtrarCandidatos(candidatosdto);
                for (int i = 0; i <= candidatos.Count(); i++)
                {
                    dataGridViewCandidatosAEvaluar.Rows.Add();
                    dataGridViewCandidatosAEvaluar.Rows[i].Cells[1].Value = candidatos[i].NumDocumento;
                    dataGridViewCandidatosAEvaluar.Rows[i].Cells[2].Value = candidatos[i].Nombre;
                    dataGridViewCandidatosAEvaluar.Rows[i].Cells[3].Value = candidatos[i].Apellido;
                }
            }
        }
    }
}
