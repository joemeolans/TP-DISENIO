using TP_DISEÑO.Properties;

namespace TP_DISEÑO
{
    partial class CDU009
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDU009));
            this.CodigoDelPuestoInput = new System.Windows.Forms.TextBox();
            this.CompletarLosSigDatos = new System.Windows.Forms.Label();
            this.labelCodigoDelPuesto = new System.Windows.Forms.Label();
            this.labelNombreDelPuesto = new System.Windows.Forms.Label();
            this.NombreDelPuestoInput = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.DescripcionInput = new System.Windows.Forms.TextBox();
            this.labelCaracteristicaDelPuesto = new System.Windows.Forms.Label();
            this.AgregarFila = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.TablaCaracterísticasDelPuesto = new System.Windows.Forms.DataGridView();
            this.Competencia = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Ponderación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Salir = new System.Windows.Forms.Button();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NombreEmpresa = new System.Windows.Forms.Label();
            this.NombreEmpresaInput = new System.Windows.Forms.ComboBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCaracterísticasDelPuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoDelPuestoInput
            // 
            this.CodigoDelPuestoInput.Location = new System.Drawing.Point(122, 225);
            this.CodigoDelPuestoInput.Name = "CodigoDelPuestoInput";
            this.CodigoDelPuestoInput.Size = new System.Drawing.Size(620, 20);
            this.CodigoDelPuestoInput.TabIndex = 1;
            // 
            // CompletarLosSigDatos
            // 
            this.CompletarLosSigDatos.AutoSize = true;
            this.CompletarLosSigDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompletarLosSigDatos.Location = new System.Drawing.Point(116, 155);
            this.CompletarLosSigDatos.Name = "CompletarLosSigDatos";
            this.CompletarLosSigDatos.Size = new System.Drawing.Size(393, 31);
            this.CompletarLosSigDatos.TabIndex = 2;
            this.CompletarLosSigDatos.Text = "Completar los siguientes datos:";
            this.CompletarLosSigDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCodigoDelPuesto
            // 
            this.labelCodigoDelPuesto.AutoSize = true;
            this.labelCodigoDelPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoDelPuesto.Location = new System.Drawing.Point(119, 205);
            this.labelCodigoDelPuesto.Name = "labelCodigoDelPuesto";
            this.labelCodigoDelPuesto.Size = new System.Drawing.Size(291, 17);
            this.labelCodigoDelPuesto.TabIndex = 3;
            this.labelCodigoDelPuesto.Text = "Código del puesto (campo obligatorio*)";
            // 
            // labelNombreDelPuesto
            // 
            this.labelNombreDelPuesto.AutoSize = true;
            this.labelNombreDelPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreDelPuesto.Location = new System.Drawing.Point(119, 258);
            this.labelNombreDelPuesto.Name = "labelNombreDelPuesto";
            this.labelNombreDelPuesto.Size = new System.Drawing.Size(297, 17);
            this.labelNombreDelPuesto.TabIndex = 4;
            this.labelNombreDelPuesto.Text = "Nombre del puesto (campo obligatorio*)";
            // 
            // NombreDelPuestoInput
            // 
            this.NombreDelPuestoInput.Location = new System.Drawing.Point(122, 278);
            this.NombreDelPuestoInput.Name = "NombreDelPuestoInput";
            this.NombreDelPuestoInput.Size = new System.Drawing.Size(620, 20);
            this.NombreDelPuestoInput.TabIndex = 2;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(119, 312);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(245, 17);
            this.labelDescripcion.TabIndex = 6;
            this.labelDescripcion.Text = "Descripción (campo obligatorio*)";
            // 
            // DescripcionInput
            // 
            this.DescripcionInput.Location = new System.Drawing.Point(122, 332);
            this.DescripcionInput.Multiline = true;
            this.DescripcionInput.Name = "DescripcionInput";
            this.DescripcionInput.Size = new System.Drawing.Size(620, 89);
            this.DescripcionInput.TabIndex = 3;
            // 
            // labelCaracteristicaDelPuesto
            // 
            this.labelCaracteristicaDelPuesto.AutoSize = true;
            this.labelCaracteristicaDelPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaracteristicaDelPuesto.Location = new System.Drawing.Point(119, 489);
            this.labelCaracteristicaDelPuesto.Name = "labelCaracteristicaDelPuesto";
            this.labelCaracteristicaDelPuesto.Size = new System.Drawing.Size(349, 17);
            this.labelCaracteristicaDelPuesto.TabIndex = 8;
            this.labelCaracteristicaDelPuesto.Text = "Características del puesto (campo obligatorio*)";
            // 
            // AgregarFila
            // 
            this.AgregarFila.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AgregarFila.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AgregarFila.FlatAppearance.BorderSize = 3;
            this.AgregarFila.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.AgregarFila.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.AgregarFila.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.AgregarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarFila.Location = new System.Drawing.Point(364, 710);
            this.AgregarFila.Name = "AgregarFila";
            this.AgregarFila.Size = new System.Drawing.Size(104, 31);
            this.AgregarFila.TabIndex = 6;
            this.AgregarFila.Text = "Agregar fila";
            this.AgregarFila.UseVisualStyleBackColor = false;
            this.AgregarFila.Click += new System.EventHandler(this.AgregarFila_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Aceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Aceptar.FlatAppearance.BorderSize = 3;
            this.Aceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.Aceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.Aceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aceptar.Location = new System.Drawing.Point(741, 791);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(103, 39);
            this.Aceptar.TabIndex = 7;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = false;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // TablaCaracterísticasDelPuesto
            // 
            this.TablaCaracterísticasDelPuesto.AllowUserToAddRows = false;
            this.TablaCaracterísticasDelPuesto.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.TablaCaracterísticasDelPuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TablaCaracterísticasDelPuesto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.TablaCaracterísticasDelPuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCaracterísticasDelPuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Competencia,
            this.Ponderación,
            this.Eliminar});
            this.TablaCaracterísticasDelPuesto.Location = new System.Drawing.Point(122, 509);
            this.TablaCaracterísticasDelPuesto.Name = "TablaCaracterísticasDelPuesto";
            this.TablaCaracterísticasDelPuesto.RowHeadersVisible = false;
            this.TablaCaracterísticasDelPuesto.Size = new System.Drawing.Size(620, 166);
            this.TablaCaracterísticasDelPuesto.TabIndex = 5;
            this.TablaCaracterísticasDelPuesto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaCaracterísticasDelPuesto_CellContentClick);
            // 
            // Competencia
            // 
            this.Competencia.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Competencia.HeaderText = "Competencia";
            this.Competencia.Name = "Competencia";
            this.Competencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Competencia.Sorted = true;
            this.Competencia.Width = 270;
            // 
            // Ponderación
            // 
            this.Ponderación.HeaderText = "Ponderación";
            this.Ponderación.Name = "Ponderación";
            this.Ponderación.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Ponderación.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Ponderación.Width = 230;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::TP_DISEÑO.Properties.Resources.tachitodebasura;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Salir.FlatAppearance.BorderSize = 3;
            this.Salir.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(21, 791);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(103, 39);
            this.Salir.TabIndex = 9;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CerrarSesion.FlatAppearance.BorderSize = 3;
            this.CerrarSesion.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.CerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.CerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesion.Location = new System.Drawing.Point(713, 25);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(131, 39);
            this.CerrarSesion.TabIndex = 10;
            this.CerrarSesion.Text = "Cerrar Sesión";
            this.CerrarSesion.UseVisualStyleBackColor = false;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // NombreEmpresa
            // 
            this.NombreEmpresa.AutoSize = true;
            this.NombreEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEmpresa.Location = new System.Drawing.Point(119, 436);
            this.NombreEmpresa.Name = "NombreEmpresa";
            this.NombreEmpresa.Size = new System.Drawing.Size(324, 17);
            this.NombreEmpresa.TabIndex = 17;
            this.NombreEmpresa.Text = "Nombre de la empresa (campo obligatorio*)";
            // 
            // NombreEmpresaInput
            // 
            this.NombreEmpresaInput.FormattingEnabled = true;
            this.NombreEmpresaInput.Location = new System.Drawing.Point(122, 456);
            this.NombreEmpresaInput.Name = "NombreEmpresaInput";
            this.NombreEmpresaInput.Size = new System.Drawing.Size(620, 21);
            this.NombreEmpresaInput.Sorted = true;
            this.NombreEmpresaInput.TabIndex = 4;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Cancelar.FlatAppearance.BorderSize = 3;
            this.Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(614, 791);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(103, 39);
            this.Cancelar.TabIndex = 8;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(470, 679);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "(*) Como mínimo debe haber una competencia";
            // 
            // CDU009
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(870, 861);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.NombreEmpresaInput);
            this.Controls.Add(this.NombreEmpresa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.TablaCaracterísticasDelPuesto);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.AgregarFila);
            this.Controls.Add(this.labelCaracteristicaDelPuesto);
            this.Controls.Add(this.DescripcionInput);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.NombreDelPuestoInput);
            this.Controls.Add(this.labelNombreDelPuesto);
            this.Controls.Add(this.labelCodigoDelPuesto);
            this.Controls.Add(this.CompletarLosSigDatos);
            this.Controls.Add(this.CodigoDelPuestoInput);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "CDU009";
            this.Padding = new System.Windows.Forms.Padding(150);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDU009-DarDeAltaPuesto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaCaracterísticasDelPuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CodigoDelPuestoInput;
        private System.Windows.Forms.Label CompletarLosSigDatos;
        private System.Windows.Forms.Label labelCodigoDelPuesto;
        private System.Windows.Forms.Label labelNombreDelPuesto;
        private System.Windows.Forms.TextBox NombreDelPuestoInput;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.TextBox DescripcionInput;
        private System.Windows.Forms.Label labelCaracteristicaDelPuesto;
        private System.Windows.Forms.Button AgregarFila;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.DataGridView TablaCaracterísticasDelPuesto;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button CerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NombreEmpresa;
        private System.Windows.Forms.ComboBox NombreEmpresaInput;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ponderación;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}

