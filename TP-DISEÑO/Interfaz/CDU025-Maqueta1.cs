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
using TP_DISEÑO.Gestores;

namespace TP_DISEÑO.Interfaz
{
    public partial class CDU0025_Maqueta1 : Form
    {
        public List<int> lisIdCand = new List<int>();
        string NombreUsuario;
        public CDU0025_Maqueta1(string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            Form volverAlMenu = new MenuPrincipal(NombreUsuario);
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
            if(dataGridViewCandidatosAEvaluar.Rows.Count == 0)
            {
                MessageBox.Show("No ha agregado ningún candidato a la lista de Candidatos a Evaluar. Por favor agregue alguno.");
            }
            else
            {
                List<CandidatoDTO> cand = new List<CandidatoDTO>();
                foreach (DataGridViewRow fila in dataGridViewCandidatosAEvaluar.Rows)
                {
                    CandidatoDTO cDTO = new CandidatoDTO();
                    cDTO.IdCandidato = Int32.Parse(fila.Cells[1].Value.ToString());
                    cDTO.Nombre = fila.Cells[2].Value.ToString();
                    cDTO.Apellido = fila.Cells[3].Value.ToString();
                    cand.Add(cDTO);
                }
                foreach(CandidatoDTO oCandDTO in cand)
                {
                    lisIdCand.Add(oCandDTO.IdCandidato);
                }
                Form irAMaqueta2 = new CDU025_Maqueta2(lisIdCand, NombreUsuario);
                irAMaqueta2.Show();
                this.Hide();
            }
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
            /*Ver si esta bien esto*/
            GestorEvaluacion gestorEval = new GestorEvaluacion();
            List<CandidatoDTO> listCand = new List<CandidatoDTO>();
            foreach(DataGridViewRow ocand in dataGridViewListaCandidatos.Rows)
            {
                CandidatoDTO candidatoDTO = new CandidatoDTO();
                candidatoDTO.IdCandidato = Int32.Parse(ocand.Cells[1].Value.ToString());
                candidatoDTO.Nombre = ocand.Cells[2].Value.ToString();
                candidatoDTO.Apellido = ocand.Cells[3].Value.ToString();
                listCand.Add(candidatoDTO);
            }
            List<int> IdCandidatosInvalidos = gestorEval.filtrarCandidatos(listCand);
            if (!(IdCandidatosInvalidos == null))
            {
                string error = "Los usuarios con los siguientes Numero de candidato ya tienen cuestionarios activos: ";
                foreach (int id in IdCandidatosInvalidos)
                {
                    MessageBox.Show(error /*id.ToString()*/);
                }
            }
            else
            {
                /*Hasta aca*/
                foreach (DataGridViewRow fila in dataGridViewListaCandidatos.Rows)
                {

                    if (fila.Cells[0].Value != null && fila.Cells[0].Value.Equals(true))
                    {
                        for (int j = 0; j < dataGridViewCandidatosAEvaluar.Rows.Count; j++)
                        {
                            if (dataGridViewCandidatosAEvaluar.Rows[j].Cells[1].Value.Equals(fila.Cells[1].Value))
                            {
                                resultado = true;
                                break;
                            }
                            else
                            {
                                resultado = false;
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
        }

        private void BotonQuitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dataGridViewCandidatosAEvaluar.Rows)
            {
                if (fila.Cells[0].Value != null && fila.Cells[0].Value.Equals(true))
                {
                    dataGridViewCandidatosAEvaluar.Rows.RemoveAt(fila.Index);
                    
                }
            }
        }
    }
}
