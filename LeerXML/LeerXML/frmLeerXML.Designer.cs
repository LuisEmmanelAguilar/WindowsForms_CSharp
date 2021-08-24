namespace LeerXML
{
    partial class frmLeerXML
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
            this.LBArchivos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRutaDirectorio = new System.Windows.Forms.TextBox();
            this.btnLeerXML = new System.Windows.Forms.Button();
            this.btnLeerCfdiNomina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBArchivos
            // 
            this.LBArchivos.FormattingEnabled = true;
            this.LBArchivos.Location = new System.Drawing.Point(12, 85);
            this.LBArchivos.Name = "LBArchivos";
            this.LBArchivos.Size = new System.Drawing.Size(331, 186);
            this.LBArchivos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar Directorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRutaDirectorio
            // 
            this.txtRutaDirectorio.Location = new System.Drawing.Point(12, 60);
            this.txtRutaDirectorio.Name = "txtRutaDirectorio";
            this.txtRutaDirectorio.Size = new System.Drawing.Size(331, 20);
            this.txtRutaDirectorio.TabIndex = 3;
            // 
            // btnLeerXML
            // 
            this.btnLeerXML.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLeerXML.Location = new System.Drawing.Point(12, 277);
            this.btnLeerXML.Name = "btnLeerXML";
            this.btnLeerXML.Size = new System.Drawing.Size(110, 40);
            this.btnLeerXML.TabIndex = 4;
            this.btnLeerXML.Text = "Leer XML";
            this.btnLeerXML.UseVisualStyleBackColor = false;
            this.btnLeerXML.Click += new System.EventHandler(this.btnLeerXML_Click);
            // 
            // btnLeerCfdiNomina
            // 
            this.btnLeerCfdiNomina.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLeerCfdiNomina.Location = new System.Drawing.Point(232, 277);
            this.btnLeerCfdiNomina.Name = "btnLeerCfdiNomina";
            this.btnLeerCfdiNomina.Size = new System.Drawing.Size(111, 40);
            this.btnLeerCfdiNomina.TabIndex = 5;
            this.btnLeerCfdiNomina.Text = "Leer CFDI Nomina";
            this.btnLeerCfdiNomina.UseVisualStyleBackColor = false;
            this.btnLeerCfdiNomina.Click += new System.EventHandler(this.btnLeerCfdiNomina_Click);
            // 
            // frmLeerXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 359);
            this.Controls.Add(this.btnLeerCfdiNomina);
            this.Controls.Add(this.btnLeerXML);
            this.Controls.Add(this.txtRutaDirectorio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBArchivos);
            this.Name = "frmLeerXML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leer XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBArchivos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRutaDirectorio;
        private System.Windows.Forms.Button btnLeerXML;
        private System.Windows.Forms.Button btnLeerCfdiNomina;
    }
}

