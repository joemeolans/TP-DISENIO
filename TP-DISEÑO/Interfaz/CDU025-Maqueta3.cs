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
    public partial class CDU025_Maqueta3 : Form
    {
        List<int> candidatoList;
        List<CandidatoDTO> candidatoDTOs =  new List<CandidatoDTO>();
        public CDU025_Maqueta3(List<int> Idcandtos)
        {
            candidatoList = Idcandtos;
            InitializeComponent();
            GestorCandidato gestorCand = new GestorCandidato();
            foreach(int id in candidatoList)
            {
                candidato oCandidato = gestorCand.GetCandidatoById2(id);
                CandidatoDTO ocandidatoDTO = new CandidatoDTO();
                ocandidatoDTO.IdCandidato = oCandidato.IdCandidato;
                ocandidatoDTO.Nombre = oCandidato.Nombre;
                ocandidatoDTO.Apellido = oCandidato.Apellido;
                candidatoDTOs.Add(ocandidatoDTO);
            }
            int i = dataGridViewCandidatos.Rows.Count;
            dataGridViewCandidatos.Rows.Clear();
            foreach (CandidatoDTO cDTO in candidatoDTOs)
            {
                dataGridViewCandidatos.Rows.Add();
                dataGridViewCandidatos.Rows[i].Cells[0].Value = cDTO.IdCandidato;
                dataGridViewCandidatos.Rows[i].Cells[1].Value = cDTO.Nombre;
                dataGridViewCandidatos.Rows[i].Cells[2].Value = cDTO.Apellido;
                i++;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Form volverAMaqueta2 = new CDU025_Maqueta2(candidatoList);
            volverAMaqueta2.Show();
            this.Hide();
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void CDU025_Maqueta3_Load(object sender, EventArgs e)
        {

        }

    }
}
