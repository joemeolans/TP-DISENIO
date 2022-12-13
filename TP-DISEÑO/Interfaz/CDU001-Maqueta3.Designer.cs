namespace TP_DISEÑO.Interfaz
{
    partial class CDU001_Maqueta3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CDU001_Maqueta3));
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.ClaveInput = new System.Windows.Forms.TextBox();
            this.textClave = new System.Windows.Forms.Label();
            this.textTipo = new System.Windows.Forms.Label();
            this.NroDocumentoInput = new System.Windows.Forms.TextBox();
            this.textNumDoc = new System.Windows.Forms.Label();
            this.TipoInput = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BordeFotoCapitalHumano = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordeFotoCapitalHumano)).BeginInit();
            this.SuspendLayout();
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
            this.botonVolver.Location = new System.Drawing.Point(27, 498);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(103, 39);
            this.botonVolver.TabIndex = 19;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.botonAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonAceptar.FlatAppearance.BorderSize = 3;
            this.botonAceptar.FlatAppearance.CheckedBackColor = System.Drawing.Color.PaleTurquoise;
            this.botonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.botonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.botonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAceptar.Location = new System.Drawing.Point(741, 498);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(103, 39);
            this.botonAceptar.TabIndex = 18;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = false;
            this.botonAceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // ClaveInput
            // 
            this.ClaveInput.Location = new System.Drawing.Point(187, 364);
            this.ClaveInput.Name = "ClaveInput";
            this.ClaveInput.Size = new System.Drawing.Size(509, 20);
            this.ClaveInput.TabIndex = 15;
            this.ClaveInput.UseSystemPasswordChar = true;
            // 
            // textClave
            // 
            this.textClave.AutoSize = true;
            this.textClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClave.Location = new System.Drawing.Point(184, 344);
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(200, 17);
            this.textClave.TabIndex = 17;
            this.textClave.Text = "Clave (campo obligatorio*)";
            // 
            // textTipo
            // 
            this.textTipo.AutoSize = true;
            this.textTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTipo.Location = new System.Drawing.Point(184, 291);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(192, 17);
            this.textTipo.TabIndex = 16;
            this.textTipo.Text = "Tipo (campo obligatorio*)";
            // 
            // NroDocumentoInput
            // 
            this.NroDocumentoInput.Location = new System.Drawing.Point(414, 311);
            this.NroDocumentoInput.Name = "NroDocumentoInput";
            this.NroDocumentoInput.Size = new System.Drawing.Size(282, 20);
            this.NroDocumentoInput.TabIndex = 14;
            // 
            // textNumDoc
            // 
            this.textNumDoc.AutoSize = true;
            this.textNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumDoc.Location = new System.Drawing.Point(411, 291);
            this.textNumDoc.Name = "textNumDoc";
            this.textNumDoc.Size = new System.Drawing.Size(285, 17);
            this.textNumDoc.TabIndex = 20;
            this.textNumDoc.Text = "N° de documento (campo obligatorio*)";
            // 
            // TipoInput
            // 
            this.TipoInput.FormattingEnabled = true;
            this.TipoInput.Items.AddRange(new object[] {
            "DNI",
            "Libreta Civica",
            "Libreta Enrolamiento"});
            this.TipoInput.Location = new System.Drawing.Point(187, 311);
            this.TipoInput.Name = "TipoInput";
            this.TipoInput.Size = new System.Drawing.Size(221, 21);
            this.TipoInput.TabIndex = 21;
            this.TipoInput.Text = "Selecciona un tipo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // BordeFotoCapitalHumano
            // 
            this.BordeFotoCapitalHumano.BackColor = System.Drawing.Color.MediumTurquoise;
            this.BordeFotoCapitalHumano.Location = new System.Drawing.Point(344, 57);
            this.BordeFotoCapitalHumano.Name = "BordeFotoCapitalHumano";
            this.BordeFotoCapitalHumano.Size = new System.Drawing.Size(183, 180);
            this.BordeFotoCapitalHumano.TabIndex = 13;
            this.BordeFotoCapitalHumano.TabStop = false;
            // 
            // CDU001_Maqueta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(870, 561);
            this.Controls.Add(this.TipoInput);
            this.Controls.Add(this.textNumDoc);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.ClaveInput);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.NroDocumentoInput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BordeFotoCapitalHumano);
            this.Name = "CDU001_Maqueta3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CDU001_Maqueta3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordeFotoCapitalHumano)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox ClaveInput;
        private System.Windows.Forms.Label textClave;
        private System.Windows.Forms.Label textTipo;
        private System.Windows.Forms.TextBox NroDocumentoInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BordeFotoCapitalHumano;
        private System.Windows.Forms.Label textNumDoc;
        private System.Windows.Forms.ComboBox TipoInput;
    }
}