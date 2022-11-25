using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_DISEÑO.Interfaz;

namespace TP_DISEÑO
{
    public partial class CDU009 : Form
    {
        
        public CDU009()
        {
            InitializeComponent();
        }

        Gestores.GestorPuesto gestor { get; set; }
        DTO.PuestoBuscadoDTO puestodto { get; set;}

        private void Form1_Load(object sender, EventArgs e)
        {
            Gestores.GestorPuesto gestor = new Gestores.GestorPuesto();
            

            List<String> empresas = gestor.GetAllEmpresas();
            List<String> competencias = gestor.GetAllCompetencias();

            foreach (String r in empresas){
            NombreEmpresaInput.Items.Add(r);
            }
            foreach (String t in competencias)
            {
                Competencia.Items.Add(t);
            }

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Form vueltaAlMenu = new MenuPrincipal();
            vueltaAlMenu.Show();
            this.Hide();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Form volverAGestionarPuesto = new CDU008();
            volverAGestionarPuesto.Show();
            this.Hide();
        }

        private void AgregarFila_Click(object sender, EventArgs e)
        {
            TablaCaracterísticasDelPuesto.Rows.Add();
        }

        private void TablaCaracterísticasDelPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.TablaCaracterísticasDelPuesto.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                TablaCaracterísticasDelPuesto.Rows.Remove(TablaCaracterísticasDelPuesto.CurrentRow);
            }
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string MensajeError = "DATOS INCOMPLETOS:\n\n";
            bool HayError = false;
            string MensajeErrorLogico = "DATOS INCORRECTOS:\n\n";
            bool HayErrorLogico = false;
            if (string.IsNullOrWhiteSpace(CodigoDelPuestoInput.Text))
            {
                MensajeError += "Debe ingresar un código para el nuevo puesto.\n";
                HayError = true;
            }
            if (string.IsNullOrWhiteSpace(NombreDelPuestoInput.Text))
            {
                MensajeError += "Debe ingresar un nombre para el nuevo puesto.\n";
                HayError = true;
            }
            if (string.IsNullOrWhiteSpace(DescripcionInput.Text))
            {
                MensajeError += "Debe ingresar una descripción para el nuevo puesto.\n";
                HayError = true;
            }
            if (NombreEmpresaInput.SelectedIndex==-1)
            {
                MensajeError += "Debe seleccionar un nombre de empresa para el nuevo puesto.\n";
                HayError = true;
            }
            if (TablaCaracterísticasDelPuesto.Rows.Count < 1)
            {
                MensajeError += "Debes agregar como mínimo una competencia con su ponderacion minima correspondiente.\n";
                HayError = true;
            }
                /*VALIDAR QUE FALTA*/
                
                foreach(DataGridViewRow fila in TablaCaracterísticasDelPuesto.Rows)
                {
                    if (fila.Cells[0].Value == null)
                    {
                        MensajeError += "Falta seleccionar una competencia.\n";
                        HayError = true;
                    }
                    else if (fila.Cells[1].Value == null)
                    {
                        MensajeError += "Falta colocar una ponderación.\n";
                        HayError = true;
                    }
                    
                    else
                    {
                        try
                        {
                            int puntaje = Int32.Parse(fila.Cells[1].Value.ToString());
                        }
                        catch
                        {
                            MensajeError += "Una ponderación ingresada no es un número entero entre 1 y 100.\n";
                            HayError = true;
                        }
                    }
                }

            if (HayError)
            {
                MessageBox.Show(MensajeError);
            }
            else if(!(HayError))
            {
                Gestores.GestorPuesto gestor = new Gestores.GestorPuesto();
                DTO.PuestoBuscadoDTO puestodto = new DTO.PuestoBuscadoDTO();
                puestodto.codigo = CodigoDelPuestoInput.Text;
                puestodto.nombre = NombreDelPuestoInput.Text;
                puestodto.descripcion = DescripcionInput.Text;
                puestodto.nombreEmpresa = NombreEmpresaInput.Text;

                foreach (DataGridViewRow r in TablaCaracterísticasDelPuesto.Rows)
                {
                    try 
                    {
                        puestodto.nombreCompetencias.Add(r.Cells[0].Value.ToString());
                        int puntaje = Int32.Parse(r.Cells[1].Value.ToString());
                        puestodto.puntajesM.Add(puntaje);
                    }
                    catch
                    {
                        MensajeErrorLogico += "Ponderación inválida (debe ser un entero).\n";
                        HayErrorLogico = true;
                    }
                }
                List<int> errores = gestor.AltaPuesto(puestodto);
                if(errores.Count > 0)
                {
                    foreach (int error in errores)
                    {
                       if(error == 1)
                       {
                            MensajeErrorLogico += "Nombre del puesto inválido.\n";
                            HayErrorLogico = true;
                       }
                        if (error == 2)
                        {
                            MensajeErrorLogico += "Descripción inválida.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 3)
                        {
                            MensajeErrorLogico += "Nombre de empresa inválido.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 4)
                        {
                            MensajeErrorLogico += "No existe la empresa especificada.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 5)
                        {
                            MensajeErrorLogico += "Ponderación inválida.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 6)
                        {
                            MensajeErrorLogico += "Competencia inválida.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 7)
                        {
                            MensajeErrorLogico += "No existe la competencia especificada.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 8)
                        {
                            MensajeErrorLogico += "No hay la misma cantidad de puntajes mínimos que de competencias.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 9)
                        {
                            MensajeErrorLogico += "Ya existe ese nombre de puesto para la empresa seleccionada.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 10)
                        {
                            MensajeErrorLogico += "Ya existe ese código de puesto para la empresa seleccionada.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 11)
                        {
                            MensajeErrorLogico += "Código inválido.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 12)
                        {
                            MensajeErrorLogico += "Hay competencias repetidas.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 13)
                        {
                            MensajeErrorLogico += "El nombre del puesto contiene mas de 50 caracteres.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 14)
                        {
                            MensajeErrorLogico += "El código del puesto contiene mas de 10 caracteres.\n";
                            HayErrorLogico = true;
                        }
                        if (error == 15)
                        {
                            MensajeErrorLogico += "La descripción del puesto contiene mas de 150 caracteres.\n";
                            HayErrorLogico = true;
                        }
                    }
                }

                if (HayErrorLogico)
                {
                    MessageBox.Show(MensajeErrorLogico);
                }
                else
                {
                    Form volverAGestionarPuesto = new CDU008();
                    MessageBox.Show("Puesto creado correctamente.");
                    volverAGestionarPuesto.Show();
                    this.Hide();
                }
            }
        }
    }
}
