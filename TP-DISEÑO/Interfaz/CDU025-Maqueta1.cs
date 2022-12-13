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
                if (ApellidoInput.Text == null)
                {
                    candidatosdto.Apellido = null;
                }
                else
                {
                    candidatosdto.Apellido = ApellidoInput.Text;
                }
                if (NombreInput.Text == null)
                {
                    candidatosdto.Nombre = null;
                }
                else
                {
                    candidatosdto.Nombre = NombreInput.Text;
                }
                try 
                {
                    if(NroCandidatoInput.Text == null)
                    {
                        candidatosdto.IdCandidato = 0;
                    }
                    else
                    {
                        candidatosdto.IdCandidato = Int32.Parse(NroCandidatoInput.Text.ToString());
                    }
                }
                catch (Exception exec)
                {
                    Console.WriteLine("{0} Exception caught.", exec);
                }

                List<DTO.CandidatoDTO> candidatos = gestorCandidato.filtrarCandidatos(candidatosdto);
                int i = 0;
                dataGridViewListaCandidatos.Rows.Clear();
                foreach(var candidato in candidatos)
                {
                    dataGridViewListaCandidatos.Rows.Add();
                    dataGridViewListaCandidatos.Rows[i].Cells[1].Value = candidatos[i].IdCandidato;
                    dataGridViewListaCandidatos.Rows[i].Cells[2].Value = candidatos[i].Nombre;
                    dataGridViewListaCandidatos.Rows[i].Cells[3].Value = candidatos[i].Apellido;
                    i++;
                }
            }
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            int i = dataGridViewCandidatosAEvaluar.Rows.Count;
            foreach (DataGridViewRow fila in dataGridViewListaCandidatos.Rows)
            {
                
                if(fila.Cells[0].Value != null && fila.Cells[0].Value.Equals(true))
                {
                    for (int j = 0; j < dataGridViewCandidatosAEvaluar.Rows.Count; j++)
                    {
                        if (dataGridViewCandidatosAEvaluar.Rows[j].Cells[1].Value.Equals(fila.Cells[1].Value))
                        {
                            resultado = true;
                        }
                    }
                    if (resultado == false)
                    {
                        dataGridViewCandidatosAEvaluar.Rows.Add();
                        dataGridViewCandidatosAEvaluar.Rows[i].Cells[1].Value = fila.Cells[1].Value;
                        dataGridViewCandidatosAEvaluar.Rows[i].Cells[2].Value = fila.Cells[2].Value;
                        dataGridViewCandidatosAEvaluar.Rows[i].Cells[3].Value = fila.Cells[3].Value;
                        i++;
                    }
                    
                }
            }
        }

        private void BotonQuitar_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (DataGridViewRow fila in dataGridViewCandidatosAEvaluar.Rows)
            {
                if (fila.Cells[0].Value.ToString() == "1")
                {
                    dataGridViewListaCandidatos.Rows.Add();
                    dataGridViewListaCandidatos.Rows[i].Cells[1].Value = fila.Cells[1].Value;
                    dataGridViewListaCandidatos.Rows[i].Cells[2].Value = fila.Cells[2].Value;
                    dataGridViewListaCandidatos.Rows[i].Cells[3].Value = fila.Cells[3].Value;
                    i++;
                }
            }
        }
    }
}
