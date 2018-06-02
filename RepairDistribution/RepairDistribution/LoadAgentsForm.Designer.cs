namespace RepairDistribution
{
    partial class LoadAgentsForm
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
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.btnAccept = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.btnOpenFile.Location = new System.Drawing.Point(16, 32);
			this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(121, 31);
			this.btnOpenFile.TabIndex = 0;
			this.btnOpenFile.Text = "Open File";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// txtFileName
			// 
			this.txtFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.txtFileName.Location = new System.Drawing.Point(165, 36);
			this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(333, 22);
			this.txtFileName.TabIndex = 1;
			this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
			// 
			// btnAccept
			// 
			this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.btnAccept.Location = new System.Drawing.Point(349, 84);
			this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(151, 31);
			this.btnAccept.TabIndex = 2;
			this.btnAccept.Text = "Ready";
			this.btnAccept.UseVisualStyleBackColor = true;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// LoadAgentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(516, 161);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.btnOpenFile);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "LoadAgentsForm";
			this.Text = "LoadAgentsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnAccept;
    }
}