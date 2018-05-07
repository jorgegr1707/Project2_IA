namespace RepairDistribution
{
    partial class Form1
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
            this.btn_openfile = new System.Windows.Forms.Button();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(12, 12);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(96, 27);
            this.btn_openfile.TabIndex = 0;
            this.btn_openfile.Text = "Open File";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(128, 16);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(184, 20);
            this.txt_filename.TabIndex = 1;
            // 
            // txt_filepath
            // 
            this.txt_filepath.Location = new System.Drawing.Point(12, 45);
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.Size = new System.Drawing.Size(300, 20);
            this.txt_filepath.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 205);
            this.Controls.Add(this.txt_filepath);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.btn_openfile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.TextBox txt_filepath;
    }
}

