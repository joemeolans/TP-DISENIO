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
            if( ((TipoInput.Text) == "Selecciona un tipo") || (string.IsNullOrWhiteSpace(NroDocumentoInput.Text)) || (string.IsNullOrWhiteSpace(ClaveInput.Text)))
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                Gestores.GestorCandidato gestorCandidato = new Gestores.GestorCandidato();
                DTO.CandidatoDTO candidatodto = new DTO.CandidatoDTO();
                candidatodto.Tipo = TipoInput.Text;
                //PREGUNTAR COMO TRATARLO (TRY/CATCH)
                candidatodto.NumDocumento = Int32.Parse(NroDocumentoInput.Text.ToString());
                candidatodto.Clave = ClaveInput.Text;
       
                    int ingreso = gestorCandidato.realizarCuestionario(candidatodto);
                    if (ingreso == 0)
                    {
                        MessageBox.Show("No existe cuestionario activo para dicho candidato.");
                    }
                    else if(ingreso == -1)
                    {
                        MessageBox.Show("El tipo de documento y/o el número de documento y/o la clave son incorrectos.");
                    }
                    else
                    {
                        Form ingresarARealizarCuestionario = new CDU026_Maqueta1();
                        ingresarARealizarCuestionario.Show();
                        this.Hide();
                    }
            }
        }
    }
}
