namespace TP_DISEÑO.Interfaz
{
    partial class CDU008
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NuevoPuesto = new System.Windows.Forms.Button();
            this.VolverAlMenu = new System.Windows.Forms.Button();
            this.MensajeAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NuevoPuesto
            // 
            this.NuevoPuesto.BackColor = System.Drawing.Color.MediumTurquoise;
            this.NuevoPuesto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NuevoPuesto.FlatAppearance.BorderSize = 3;
            this.NuevoPuesto.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.NuevoPuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.NuevoPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.NuevoPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NuevoPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoPuesto.Location = new System.Drawing.Point(219, 213);
            this.NuevoPuesto.Name = "NuevoPuesto";
            this.NuevoPuesto.Size = new System.Drawing.Size(213, 64);
            this.NuevoPuesto.TabIndex = 0;
            this.NuevoPuesto.Text = "Nuevo puesto";
            this.NuevoPuesto.UseVisualStyleBackColor = false;
            this.NuevoPuesto.Click += new System.EventHandler(this.NuevoPuesto_Click);
            // 
            // VolverAlMenu
            // 
            this.VolverAlMenu.BackColor = System.Drawing.Color.MediumTurquoise;
            this.VolverAlMenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.VolverAlMenu.FlatAppearance.BorderSize = 3;
            this.VolverAlMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.VolverAlMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.VolverAlMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.VolverAlMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VolverAlMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverAlMenu.Location = new System.Drawing.Point(219, 298);
            this.VolverAlMenu.Name = "VolverAlMenu";
            this.VolverAlMenu.Size = new System.Drawing.Size(213, 64);
            this.VolverAlMenu.TabIndex = 1;
            this.VolverAlMenu.Text = "Volver al menú";
            this.VolverAlMenu.UseVisualStyleBackColor = false;
            this.VolverAlMenu.Click += new System.EventHandler(this.VolverAlMenu_Click);
            // 
            // MensajeAviso
            // 
            this.MensajeAviso.AutoSize = true;
            this.MensajeAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MensajeAviso.Location = new System.Drawing.Point(205, 175);
            this.MensajeAviso.Name = "MensajeAviso";
            this.MensajeAviso.Size = new System.Drawing.Size(242, 20);
            this.MensajeAviso.TabIndex = 2;
            this.MensajeAviso.Text = "NO ESTA HECHO (ETAPA 8)";
            // 
            // CDU008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(870, 861);
            this.Controls.Add(this.MensajeAviso);
            this.Controls.Add(this.VolverAlMenu);
            this.Controls.Add(this.NuevoPuesto);
            this.Name = "CDU008";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDU008-GestionarPuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NuevoPuesto;
        private System.Windows.Forms.Button VolverAlMenu;
        private System.Windows.Forms.Label MensajeAviso;
    }
}