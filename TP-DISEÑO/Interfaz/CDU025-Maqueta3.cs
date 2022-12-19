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
        string nPuesto;
        string nEmpresa;
        string nUsuario;
        public CDU025_Maqueta3(List<int> Idcandtos, string nombrePuesto, string nombreEmpresa, string nombreUsuario)
        {
            candidatoList = Idcandtos;
            nPuesto = nombrePuesto;
            nEmpresa = nombreEmpresa;
            nUsuario = nombreUsuario;
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            GestorEvaluacion gestorEv = new GestorEvaluacion();
            InitializeComponent();
            GestorCandidato gestorCand = new GestorCandidato();
            foreach(int id in candidatoList)
            {
                candidato oCandidato = gestorCand.GetCandidatoById2(id);
                CandidatoDTO ocandidatoDTO = new CandidatoDTO();
                ocandidatoDTO.IdCandidato = oCandidato.IdCandidato;
                ocandidatoDTO.Nombre = oCandidato.Nombre;
                ocandidatoDTO.Apellido = oCandidato.Apellido;
                ocandidatoDTO.Clave = new string(Enumerable.Repeat(chars, 20).Select(s => s[random.Next(s.Length)]).ToArray());
                gestorEv.GuardarClaveCuestionario(ocandidatoDTO.Clave, ocandidatoDTO.IdCandidato);
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
                dataGridViewCandidatos.Rows[i].Cells[3].Value = cDTO.Clave;
                i++;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Form volverAMaqueta2 = new CDU025_Maqueta2(candidatoList, nUsuario);
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
        private void BotonFinalizar_Click(object sender, EventArgs e)
        {
            GestorPuesto gestorPuesto = new GestorPuesto();
            int idPuesto = gestorPuesto.GetPuestobuscadoByNombreYEmpresa(nEmpresa, nPuesto);
            GestorEvaluacion gestorEvaluacion = new GestorEvaluacion();
            int aux = gestorEvaluacion.EvaluarCandidato(idPuesto, nUsuario, candidatoDTOs);
            if (aux == 0)
            {
                if (MessageBox.Show("La evaluación falló. ¿Desea volver a intentarlo?", "Evaluación no realizada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    Form volverAIntentar = new CDU0025_Maqueta1(nUsuario);
                    volverAIntentar.Show();
                    this.Hide();
                }
                else
                {
                    Form volverMenuPrincipal = new MenuPrincipal(nUsuario);
                    volverMenuPrincipal.Show();
                    this.Hide();
                }
            }
            else
            {
                if (MessageBox.Show("La evaluación se realizó correctamente. ¿Desea realizar otra evaluación?", "Evaluación realizada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    Form volverAIntentar = new CDU0025_Maqueta1(nUsuario);
                    volverAIntentar.Show();
                    this.Hide();
                }
                else
                {
                    Form volverMenuPrincipal = new MenuPrincipal(nUsuario);
                    volverMenuPrincipal.Show();
                    this.Hide();
                }
            }
            
        }

    }
}
