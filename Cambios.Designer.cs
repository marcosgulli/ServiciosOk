namespace Servicios
{
    partial class Cambios
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
            this.lblArchivo = new System.Windows.Forms.Label();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.lstExcels = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Location = new System.Drawing.Point(31, 35);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(107, 13);
            this.lblArchivo.TabIndex = 0;
            this.lblArchivo.Text = "Seleccionar Archivos";
            // 
            // btnArchivo
            // 
            this.btnArchivo.Location = new System.Drawing.Point(144, 30);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(27, 23);
            this.btnArchivo.TabIndex = 2;
            this.btnArchivo.Text = "...";
            this.btnArchivo.UseVisualStyleBackColor = true;
            this.btnArchivo.Click += new System.EventHandler(this.btnArchivo_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(72, 244);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // lstExcels
            // 
            this.lstExcels.FormattingEnabled = true;
            this.lstExcels.Location = new System.Drawing.Point(46, 69);
            this.lstExcels.Name = "lstExcels";
            this.lstExcels.Size = new System.Drawing.Size(120, 160);
            this.lstExcels.TabIndex = 4;
            // 
            // Cambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 279);
            this.Controls.Add(this.lstExcels);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.lblArchivo);
            this.Name = "Cambios";
            this.Text = "Cambios";
            this.Load += new System.EventHandler(this.Cambios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.ListBox lstExcels;
    }
}