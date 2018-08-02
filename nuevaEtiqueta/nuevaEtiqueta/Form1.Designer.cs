namespace nuevaEtiqueta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxLogo = new System.Windows.Forms.PictureBox();
            this.nomProductor = new System.Windows.Forms.Label();
            this.nomImpresora = new System.Windows.Forms.Label();
            this.nomVariedad = new System.Windows.Forms.Label();
            this.nomEspecie = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEspecie = new System.Windows.Forms.ComboBox();
            this.comboVariedad = new System.Windows.Forms.ComboBox();
            this.comboImpresoras = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtProductor = new System.Windows.Forms.TextBox();
            this.panelEtiqueta = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVariedad = new System.Windows.Forms.Label();
            this.lblEspecie = new System.Windows.Forms.Label();
            this.lblCodProductor = new System.Windows.Forms.Label();
            this.lblNomProductor = new System.Windows.Forms.Label();
            this.imgBarcode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelEtiqueta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // boxLogo
            // 
            this.boxLogo.Image = global::nuevaEtiqueta.Properties.Resources.hf;
            this.boxLogo.Location = new System.Drawing.Point(22, 12);
            this.boxLogo.Name = "boxLogo";
            this.boxLogo.Size = new System.Drawing.Size(254, 304);
            this.boxLogo.TabIndex = 0;
            this.boxLogo.TabStop = false;
            // 
            // nomProductor
            // 
            this.nomProductor.AutoSize = true;
            this.nomProductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nomProductor.Location = new System.Drawing.Point(433, 90);
            this.nomProductor.Name = "nomProductor";
            this.nomProductor.Size = new System.Drawing.Size(124, 26);
            this.nomProductor.TabIndex = 1;
            this.nomProductor.Text = "Productor : ";
            // 
            // nomImpresora
            // 
            this.nomImpresora.AutoSize = true;
            this.nomImpresora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nomImpresora.Location = new System.Drawing.Point(433, 240);
            this.nomImpresora.Name = "nomImpresora";
            this.nomImpresora.Size = new System.Drawing.Size(122, 26);
            this.nomImpresora.TabIndex = 3;
            this.nomImpresora.Text = "Impresora :";
            // 
            // nomVariedad
            // 
            this.nomVariedad.AutoSize = true;
            this.nomVariedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nomVariedad.Location = new System.Drawing.Point(433, 190);
            this.nomVariedad.Name = "nomVariedad";
            this.nomVariedad.Size = new System.Drawing.Size(111, 26);
            this.nomVariedad.TabIndex = 4;
            this.nomVariedad.Text = "Variedad :";
            // 
            // nomEspecie
            // 
            this.nomEspecie.AutoSize = true;
            this.nomEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nomEspecie.Location = new System.Drawing.Point(433, 140);
            this.nomEspecie.Name = "nomEspecie";
            this.nomEspecie.Size = new System.Drawing.Size(102, 26);
            this.nomEspecie.TabIndex = 5;
            this.nomEspecie.Text = "Especie :";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnImprimir.Location = new System.Drawing.Point(692, 476);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(115, 39);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(433, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "N° de Cajas :";
            // 
            // comboEspecie
            // 
            this.comboEspecie.FormattingEnabled = true;
            this.comboEspecie.Location = new System.Drawing.Point(587, 146);
            this.comboEspecie.Name = "comboEspecie";
            this.comboEspecie.Size = new System.Drawing.Size(220, 21);
            this.comboEspecie.TabIndex = 2;
            this.comboEspecie.SelectedIndexChanged += new System.EventHandler(this.comboEspecie_SelectedIndexChanged);
            // 
            // comboVariedad
            // 
            this.comboVariedad.FormattingEnabled = true;
            this.comboVariedad.Location = new System.Drawing.Point(587, 196);
            this.comboVariedad.Name = "comboVariedad";
            this.comboVariedad.Size = new System.Drawing.Size(220, 21);
            this.comboVariedad.TabIndex = 3;
            this.comboVariedad.SelectedIndexChanged += new System.EventHandler(this.comboVariedad_SelectedIndexChanged);
            // 
            // comboImpresoras
            // 
            this.comboImpresoras.FormattingEnabled = true;
            this.comboImpresoras.Location = new System.Drawing.Point(587, 246);
            this.comboImpresoras.Name = "comboImpresoras";
            this.comboImpresoras.Size = new System.Drawing.Size(220, 21);
            this.comboImpresoras.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(587, 347);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(220, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtProductor
            // 
            this.txtProductor.Location = new System.Drawing.Point(587, 96);
            this.txtProductor.Name = "txtProductor";
            this.txtProductor.Size = new System.Drawing.Size(220, 20);
            this.txtProductor.TabIndex = 1;
            this.txtProductor.TextChanged += new System.EventHandler(this.txtProductor_TextChanged);
            // 
            // panelEtiqueta
            // 
            this.panelEtiqueta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEtiqueta.Controls.Add(this.imgBarcode);
            this.panelEtiqueta.Controls.Add(this.lblNomProductor);
            this.panelEtiqueta.Controls.Add(this.lblCodProductor);
            this.panelEtiqueta.Controls.Add(this.lblEspecie);
            this.panelEtiqueta.Controls.Add(this.lblVariedad);
            this.panelEtiqueta.Controls.Add(this.label2);
            this.panelEtiqueta.Location = new System.Drawing.Point(22, 340);
            this.panelEtiqueta.Name = "panelEtiqueta";
            this.panelEtiqueta.Size = new System.Drawing.Size(333, 209);
            this.panelEtiqueta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(45, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "___/___/___";
            // 
            // lblVariedad
            // 
            this.lblVariedad.AutoSize = true;
            this.lblVariedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblVariedad.Location = new System.Drawing.Point(32, 142);
            this.lblVariedad.Name = "lblVariedad";
            this.lblVariedad.Size = new System.Drawing.Size(56, 15);
            this.lblVariedad.TabIndex = 1;
            this.lblVariedad.Text = "Variedad";
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblEspecie.Location = new System.Drawing.Point(32, 127);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(51, 15);
            this.lblEspecie.TabIndex = 2;
            this.lblEspecie.Text = "Especie";
            // 
            // lblCodProductor
            // 
            this.lblCodProductor.AutoSize = true;
            this.lblCodProductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCodProductor.Location = new System.Drawing.Point(32, 112);
            this.lblCodProductor.Name = "lblCodProductor";
            this.lblCodProductor.Size = new System.Drawing.Size(89, 15);
            this.lblCodProductor.TabIndex = 3;
            this.lblCodProductor.Text = "Cod_Productor";
            // 
            // lblNomProductor
            // 
            this.lblNomProductor.AutoSize = true;
            this.lblNomProductor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNomProductor.Location = new System.Drawing.Point(32, 97);
            this.lblNomProductor.Name = "lblNomProductor";
            this.lblNomProductor.Size = new System.Drawing.Size(94, 15);
            this.lblNomProductor.TabIndex = 4;
            this.lblNomProductor.Text = "Nom_Productor";
            // 
            // imgBarcode
            // 
            this.imgBarcode.Location = new System.Drawing.Point(18, 7);
            this.imgBarcode.Name = "imgBarcode";
            this.imgBarcode.Size = new System.Drawing.Size(303, 74);
            this.imgBarcode.TabIndex = 5;
            this.imgBarcode.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelEtiqueta);
            this.Controls.Add(this.txtProductor);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboImpresoras);
            this.Controls.Add(this.comboVariedad);
            this.Controls.Add(this.comboEspecie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.nomEspecie);
            this.Controls.Add(this.nomVariedad);
            this.Controls.Add(this.nomImpresora);
            this.Controls.Add(this.nomProductor);
            this.Controls.Add(this.boxLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "EtiquetasHF";
            ((System.ComponentModel.ISupportInitialize)(this.boxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelEtiqueta.ResumeLayout(false);
            this.panelEtiqueta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox boxLogo;
        private System.Windows.Forms.Label nomProductor;
        private System.Windows.Forms.Label nomImpresora;
        private System.Windows.Forms.Label nomVariedad;
        private System.Windows.Forms.Label nomEspecie;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEspecie;
        private System.Windows.Forms.ComboBox comboVariedad;
        private System.Windows.Forms.ComboBox comboImpresoras;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtProductor;
        private System.Windows.Forms.Panel panelEtiqueta;
        private System.Windows.Forms.PictureBox imgBarcode;
        private System.Windows.Forms.Label lblNomProductor;
        private System.Windows.Forms.Label lblCodProductor;
        private System.Windows.Forms.Label lblEspecie;
        private System.Windows.Forms.Label lblVariedad;
        private System.Windows.Forms.Label label2;
    }
}

