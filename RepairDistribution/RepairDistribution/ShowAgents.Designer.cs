namespace RepairDistribution
{
	partial class ShowAgents
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLoadAgents = new System.Windows.Forms.Button();
			this.btnDistributeServiceOrders = new System.Windows.Forms.Button();
			this.btnShowServiceOrders = new System.Windows.Forms.Button();
			this.btnShowAgents = new System.Windows.Forms.Button();
			this.btnLoadServiceOrders = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.Location = new System.Drawing.Point(308, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(630, 522);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Montserrat Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(297, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(377, 62);
			this.label1.TabIndex = 1;
			this.label1.Text = "Data from Agents";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnLoadAgents);
			this.panel1.Controls.Add(this.btnDistributeServiceOrders);
			this.panel1.Controls.Add(this.btnShowServiceOrders);
			this.panel1.Controls.Add(this.btnShowAgents);
			this.panel1.Controls.Add(this.btnLoadServiceOrders);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(259, 655);
			this.panel1.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(259, 131);
			this.panel2.TabIndex = 5;
			// 
			// btnLoadAgents
			// 
			this.btnLoadAgents.FlatAppearance.BorderSize = 0;
			this.btnLoadAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadAgents.Image = global::RepairDistribution.Properties.Resources.loadagents_;
			this.btnLoadAgents.Location = new System.Drawing.Point(3, 133);
			this.btnLoadAgents.Name = "btnLoadAgents";
			this.btnLoadAgents.Size = new System.Drawing.Size(253, 99);
			this.btnLoadAgents.TabIndex = 0;
			this.btnLoadAgents.Text = "Load Agents";
			this.btnLoadAgents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLoadAgents.UseVisualStyleBackColor = true;
			// 
			// btnDistributeServiceOrders
			// 
			this.btnDistributeServiceOrders.FlatAppearance.BorderSize = 0;
			this.btnDistributeServiceOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDistributeServiceOrders.Image = global::RepairDistribution.Properties.Resources.distribution;
			this.btnDistributeServiceOrders.Location = new System.Drawing.Point(3, 553);
			this.btnDistributeServiceOrders.Name = "btnDistributeServiceOrders";
			this.btnDistributeServiceOrders.Size = new System.Drawing.Size(253, 99);
			this.btnDistributeServiceOrders.TabIndex = 4;
			this.btnDistributeServiceOrders.Text = "Distribute Service Orders";
			this.btnDistributeServiceOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDistributeServiceOrders.UseVisualStyleBackColor = true;
			// 
			// btnShowServiceOrders
			// 
			this.btnShowServiceOrders.FlatAppearance.BorderSize = 0;
			this.btnShowServiceOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowServiceOrders.Image = global::RepairDistribution.Properties.Resources.watchservices;
			this.btnShowServiceOrders.Location = new System.Drawing.Point(3, 448);
			this.btnShowServiceOrders.Name = "btnShowServiceOrders";
			this.btnShowServiceOrders.Size = new System.Drawing.Size(253, 99);
			this.btnShowServiceOrders.TabIndex = 3;
			this.btnShowServiceOrders.Text = "Show Service Orders";
			this.btnShowServiceOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnShowServiceOrders.UseVisualStyleBackColor = true;
			// 
			// btnShowAgents
			// 
			this.btnShowAgents.FlatAppearance.BorderSize = 0;
			this.btnShowAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowAgents.Image = global::RepairDistribution.Properties.Resources.watchagents;
			this.btnShowAgents.Location = new System.Drawing.Point(3, 238);
			this.btnShowAgents.Name = "btnShowAgents";
			this.btnShowAgents.Size = new System.Drawing.Size(253, 99);
			this.btnShowAgents.TabIndex = 1;
			this.btnShowAgents.Text = "Show Agents";
			this.btnShowAgents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnShowAgents.UseVisualStyleBackColor = true;
			// 
			// btnLoadServiceOrders
			// 
			this.btnLoadServiceOrders.FlatAppearance.BorderSize = 0;
			this.btnLoadServiceOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadServiceOrders.Image = global::RepairDistribution.Properties.Resources.loadservice;
			this.btnLoadServiceOrders.Location = new System.Drawing.Point(3, 343);
			this.btnLoadServiceOrders.Name = "btnLoadServiceOrders";
			this.btnLoadServiceOrders.Size = new System.Drawing.Size(253, 99);
			this.btnLoadServiceOrders.TabIndex = 2;
			this.btnLoadServiceOrders.Text = "Load Service Orders";
			this.btnLoadServiceOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLoadServiceOrders.UseVisualStyleBackColor = true;
			// 
			// ShowAgents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.ClientSize = new System.Drawing.Size(978, 655);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ShowAgents";
			this.Text = "ShowAgents";
			this.Load += new System.EventHandler(this.ShowAgents_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLoadAgents;
		private System.Windows.Forms.Button btnDistributeServiceOrders;
		private System.Windows.Forms.Button btnShowServiceOrders;
		private System.Windows.Forms.Button btnShowAgents;
		private System.Windows.Forms.Button btnLoadServiceOrders;
		private System.Windows.Forms.Panel panel2;
	}
}