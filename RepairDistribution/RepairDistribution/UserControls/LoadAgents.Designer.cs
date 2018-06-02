namespace RepairDistribution.UserControls
{
	partial class LoadAgents
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

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAccept = new System.Windows.Forms.Button();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAccept
			// 
			this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(30)))));
			this.btnAccept.Location = new System.Drawing.Point(349, 170);
			this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(151, 31);
			this.btnAccept.TabIndex = 4;
			this.btnAccept.Text = "Ready";
			this.btnAccept.UseVisualStyleBackColor = true;
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(30)))));
			this.btnOpenFile.Location = new System.Drawing.Point(38, 112);
			this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(121, 31);
			this.btnOpenFile.TabIndex = 3;
			this.btnOpenFile.Text = "Open File";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			// 
			// txtFileName
			// 
			this.txtFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.txtFileName.Location = new System.Drawing.Point(167, 121);
			this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(333, 22);
			this.txtFileName.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(353, 62);
			this.label1.TabIndex = 6;
			this.label1.Text = "Load Agents File";
			// 
			// LoadAgents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtFileName);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.btnOpenFile);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.Name = "LoadAgents";
			this.Size = new System.Drawing.Size(716, 628);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Label label1;
	}
}
