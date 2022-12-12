namespace TP_DISEÑO.Interfaz
{
    partial class CDU026_Maqueta1
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
            this.textoBienvenida = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.CerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoBienvenida
            // 
            this.textoBienvenida.AutoSize = true;
            this.textoBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoBienvenida.Location = new System.Drawing.Point(238, 215);
            this.textoBienvenida.Name = "textoBienvenida";
            this.textoBienvenida.Size = new System.Drawing.Size(429, 46);
            this.textoBienvenida.TabIndex = 0;
            this.textoBienvenida.Text = "Bienvenido al sistema!!";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.Color.MediumTurquoise;
            this.botonVolver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonVolver.FlatAppearance.BorderSize = 3;
            this.botonVolver.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.botonVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.botonVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.botonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.Location = new System.Drawing.Point(26, 801);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(103, 39);
            this.botonVolver.TabIndex = 20;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
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
            this.CerrarSesion.Location = new System.Drawing.Point(717, 21);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(131, 39);
            this.CerrarSesion.TabIndex = 26;
            this.CerrarSesion.Text = "Cerrar Sesión";
            this.CerrarSesion.UseVisualStyleBackColor = false;
            this.CerrarSesion.Click += new System.EventHandler(this.CerrarSesion_Click);
            // 
            // CDU026_Maqueta1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(870, 861);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.textoBienvenida);
            this.Name = "CDU026_Maqueta1";
            this.Text = "CDU026_Maqueta1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoBienvenida;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button CerrarSesion;
    }
}