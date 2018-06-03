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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLoadAgents = new System.Windows.Forms.Button();
			this.btnDistributeServiceOrders = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnShowServiceOrders = new System.Windows.Forms.Button();
			this.btnShowAgents = new System.Windows.Forms.Button();
			this.btnLoadServiceOrders = new System.Windows.Forms.Button();
			this.panel_image = new System.Windows.Forms.Panel();
			this.init1 = new RepairDistribution.UserControls.Init();
			this.distribute1 = new RepairDistribution.UserControls.Distribute();
			this.showServices1 = new RepairDistribution.UserControls.ShowServices();
			this.showAgents1 = new RepairDistribution.UserControls.ShowAgents();
			this.loadServices1 = new RepairDistribution.UserControls.LoadServices();
			this.loadAgentsUC = new RepairDistribution.UserControls.LoadAgents();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel_image.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLoadAgents);
			this.panel1.Controls.Add(this.btnDistributeServiceOrders);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnShowServiceOrders);
			this.panel1.Controls.Add(this.btnShowAgents);
			this.panel1.Controls.Add(this.btnLoadServiceOrders);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(259, 655);
			this.panel1.TabIndex = 5;
			// 
			// btnLoadAgents
			// 
			this.btnLoadAgents.FlatAppearance.BorderSize = 0;
			this.btnLoadAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.btnLoadAgents.Image = global::RepairDistribution.Properties.Resources.loadagents_;
			this.btnLoadAgents.Location = new System.Drawing.Point(3, 133);
			this.btnLoadAgents.Name = "btnLoadAgents";
			this.btnLoadAgents.Size = new System.Drawing.Size(253, 99);
			this.btnLoadAgents.TabIndex = 0;
			this.btnLoadAgents.Text = "Load Agents";
			this.btnLoadAgents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLoadAgents.UseVisualStyleBackColor = true;
			this.btnLoadAgents.Click += new System.EventHandler(this.btnLoadAgents_Click);
			// 
			// btnDistributeServiceOrders
			// 
			this.btnDistributeServiceOrders.FlatAppearance.BorderSize = 0;
			this.btnDistributeServiceOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDistributeServiceOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.btnDistributeServiceOrders.Image = global::RepairDistribution.Properties.Resources.distribution;
			this.btnDistributeServiceOrders.Location = new System.Drawing.Point(3, 553);
			this.btnDistributeServiceOrders.Name = "btnDistributeServiceOrders";
			this.btnDistributeServiceOrders.Size = new System.Drawing.Size(253, 99);
			this.btnDistributeServiceOrders.TabIndex = 4;
			this.btnDistributeServiceOrders.Text = "Distribute Service Orders";
			this.btnDistributeServiceOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDistributeServiceOrders.UseVisualStyleBackColor = true;
			this.btnDistributeServiceOrders.Click += new System.EventHandler(this.btnDistributeServiceOrders_Click);
			// 
			// panel2
			// 
			this.panel2.BackgroundImage = global::RepairDistribution.Properties.Resources.minilogo2;
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(259, 131);
			this.panel2.TabIndex = 0;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// btnShowServiceOrders
			// 
			this.btnShowServiceOrders.FlatAppearance.BorderSize = 0;
			this.btnShowServiceOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowServiceOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.btnShowServiceOrders.Image = global::RepairDistribution.Properties.Resources.watchservices;
			this.btnShowServiceOrders.Location = new System.Drawing.Point(3, 448);
			this.btnShowServiceOrders.Name = "btnShowServiceOrders";
			this.btnShowServiceOrders.Size = new System.Drawing.Size(253, 99);
			this.btnShowServiceOrders.TabIndex = 3;
			this.btnShowServiceOrders.Text = "Show Service Orders";
			this.btnShowServiceOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnShowServiceOrders.UseVisualStyleBackColor = true;
			this.btnShowServiceOrders.Click += new System.EventHandler(this.btnShowServiceOrders_Click);
			// 
			// btnShowAgents
			// 
			this.btnShowAgents.FlatAppearance.BorderSize = 0;
			this.btnShowAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowAgents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.btnShowAgents.Image = global::RepairDistribution.Properties.Resources.watchagents;
			this.btnShowAgents.Location = new System.Drawing.Point(3, 238);
			this.btnShowAgents.Name = "btnShowAgents";
			this.btnShowAgents.Size = new System.Drawing.Size(253, 99);
			this.btnShowAgents.TabIndex = 1;
			this.btnShowAgents.Text = "Show Agents";
			this.btnShowAgents.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnShowAgents.UseVisualStyleBackColor = true;
			this.btnShowAgents.Click += new System.EventHandler(this.btnShowAgents_Click);
			// 
			// btnLoadServiceOrders
			// 
			this.btnLoadServiceOrders.FlatAppearance.BorderSize = 0;
			this.btnLoadServiceOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoadServiceOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.btnLoadServiceOrders.Image = global::RepairDistribution.Properties.Resources.loadservice;
			this.btnLoadServiceOrders.Location = new System.Drawing.Point(3, 343);
			this.btnLoadServiceOrders.Name = "btnLoadServiceOrders";
			this.btnLoadServiceOrders.Size = new System.Drawing.Size(253, 99);
			this.btnLoadServiceOrders.TabIndex = 2;
			this.btnLoadServiceOrders.Text = "Load Service Orders";
			this.btnLoadServiceOrders.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnLoadServiceOrders.UseVisualStyleBackColor = true;
			this.btnLoadServiceOrders.Click += new System.EventHandler(this.btnLoadServiceOrders_Click);
			// 
			// panel_image
			// 
			this.panel_image.Controls.Add(this.init1);
			this.panel_image.Controls.Add(this.distribute1);
			this.panel_image.Controls.Add(this.showServices1);
			this.panel_image.Controls.Add(this.showAgents1);
			this.panel_image.Controls.Add(this.loadServices1);
			this.panel_image.Controls.Add(this.loadAgentsUC);
			this.panel_image.Location = new System.Drawing.Point(262, 24);
			this.panel_image.Name = "panel_image";
			this.panel_image.Size = new System.Drawing.Size(716, 628);
			this.panel_image.TabIndex = 6;
			this.panel_image.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_image_Paint);
			// 
			// init1
			// 
			this.init1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.init1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.init1.Location = new System.Drawing.Point(-3, 0);
			this.init1.Name = "init1";
			this.init1.Size = new System.Drawing.Size(716, 628);
			this.init1.TabIndex = 5;
			this.init1.Load += new System.EventHandler(this.init1_Load);
			// 
			// distribute1
			// 
			this.distribute1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.distribute1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.distribute1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.distribute1.Location = new System.Drawing.Point(0, 0);
			this.distribute1.Name = "distribute1";
			this.distribute1.Size = new System.Drawing.Size(716, 628);
			this.distribute1.TabIndex = 4;
			// 
			// showServices1
			// 
			this.showServices1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.showServices1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.showServices1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.showServices1.Location = new System.Drawing.Point(0, 0);
			this.showServices1.Name = "showServices1";
			this.showServices1.Size = new System.Drawing.Size(716, 628);
			this.showServices1.TabIndex = 3;
			// 
			// showAgents1
			// 
			this.showAgents1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.showAgents1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.showAgents1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.showAgents1.Location = new System.Drawing.Point(0, 0);
			this.showAgents1.Name = "showAgents1";
			this.showAgents1.Size = new System.Drawing.Size(716, 628);
			this.showAgents1.TabIndex = 2;
			// 
			// loadServices1
			// 
			this.loadServices1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.loadServices1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loadServices1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.loadServices1.Location = new System.Drawing.Point(0, 0);
			this.loadServices1.Name = "loadServices1";
			this.loadServices1.Size = new System.Drawing.Size(716, 628);
			this.loadServices1.TabIndex = 1;
			// 
			// loadAgentsUC
			// 
			this.loadAgentsUC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.loadAgentsUC.Dock = System.Windows.Forms.DockStyle.Fill;
			this.loadAgentsUC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.loadAgentsUC.Location = new System.Drawing.Point(0, 0);
			this.loadAgentsUC.Name = "loadAgentsUC";
			this.loadAgentsUC.Size = new System.Drawing.Size(716, 628);
			this.loadAgentsUC.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(259, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(719, 24);
			this.panel3.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(978, 655);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel_image);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(188)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel_image.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadAgents;
        private System.Windows.Forms.Button btnShowAgents;
        private System.Windows.Forms.Button btnLoadServiceOrders;
        private System.Windows.Forms.Button btnShowServiceOrders;
        private System.Windows.Forms.Button btnDistributeServiceOrders;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel_image;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private UserControls.LoadAgents loadAgentsUC;
		private UserControls.ShowAgents showAgents1;
		private UserControls.LoadServices loadServices1;
		private UserControls.ShowServices showServices1;
		private UserControls.Distribute distribute1;
		private UserControls.Init init1;
	}
}

