﻿using System;
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
    public partial class CDU025_Maqueta2 : Form
    {
        List<int> liscanDTO = new List<int>();
        string nombreEmpresa;
        string nombrePuesto;
        string NombreUsuario;
        public CDU025_Maqueta2(List<int> Idcandidatos, string nombreUsuario)
        {
            NombreUsuario = nombreUsuario;
            liscanDTO = Idcandidatos;
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            liscanDTO.Clear();  
            Form volverAMaqueta1 = new CDU0025_Maqueta1(NombreUsuario);
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
            nombreEmpresa = comboBoxNombreEmpresa.Text;
            nombrePuesto = comboBoxFuncionOPuesto.Text;
            Form irAMaqueta3 = new CDU025_Maqueta3(liscanDTO, nombrePuesto, nombreEmpresa, NombreUsuario);
            irAMaqueta3.Show();
            this.Hide();
        }

        private void botonFiltrar_Click(object sender, EventArgs e)
        {
            if ((comboBoxNombreEmpresa.Text.Equals("Seleccione una empresa") ) || (comboBoxFuncionOPuesto.Text.Equals("Seleccione una función o puesto")))
            {
                MessageBox.Show("Debe seleccionar todos los campos.");
            }
            else
            {
                GestorPuesto gestor = new GestorPuesto();
                List<CompetenciaDTO> competencias = gestor.GetCompetenciasByEmpresaPuesto(comboBoxNombreEmpresa.Text, comboBoxFuncionOPuesto.Text);
                foreach(CompetenciaDTO compe in competencias)
                {
                    Console.WriteLine(compe.NombreCompetencia);
                }


                int i = 0;

                dataGridViewListaCompetencias.Rows.Clear();

                foreach (CompetenciaDTO oCompetencia in competencias)
                {
                    dataGridViewListaCompetencias.Rows.Add();
                    dataGridViewListaCompetencias.Rows[i].Cells[0].Value = oCompetencia.NombreCompetencia;
                    dataGridViewListaCompetencias.Rows[i].Cells[1].Value = oCompetencia.PonderacionMinima;
                    i++;
                }

            }

        }

        private void CDU025_Maqueta2_Load(object sender, EventArgs e)
        {
            GestorPuesto gestor = new GestorPuesto();
            List<String> empresas = gestor.GetAllEmpresas();
            foreach (String r in empresas)
            {
                comboBoxNombreEmpresa.Items.Add(r);
            }
           
        }

        private void comboBoxNombreEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFuncionOPuesto.Items.Clear();
            comboBoxFuncionOPuesto.Text = "Seleccione una función o puesto"; 
            GestorPuesto gestor = new GestorPuesto();
            List<String> puestos = gestor.GetPuestosByEmpresa(comboBoxNombreEmpresa.Text);
            foreach (String r in puestos)
            {
                comboBoxFuncionOPuesto.Items.Add(r);
            }
        }
    }
}
