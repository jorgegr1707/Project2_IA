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
            this.btnLoadAgents = new System.Windows.Forms.Button();
            this.btnShowAgents = new System.Windows.Forms.Button();
            this.btnLoadServiceOrders = new System.Windows.Forms.Button();
            this.btnShowServiceOrders = new System.Windows.Forms.Button();
            this.btnDistributeServiceOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadAgents
            // 
            this.btnLoadAgents.Location = new System.Drawing.Point(230, 100);
            this.btnLoadAgents.Name = "btnLoadAgents";
            this.btnLoadAgents.Size = new System.Drawing.Size(180, 40);
            this.btnLoadAgents.TabIndex = 0;
            this.btnLoadAgents.Text = "Load Agents";
            this.btnLoadAgents.UseVisualStyleBackColor = true;
            this.btnLoadAgents.Click += new System.EventHandler(this.btnLoadAgents_Click);
            // 
            // btnShowAgents
            // 
            this.btnShowAgents.Location = new System.Drawing.Point(230, 150);
            this.btnShowAgents.Name = "btnShowAgents";
            this.btnShowAgents.Size = new System.Drawing.Size(180, 40);
            this.btnShowAgents.TabIndex = 1;
            this.btnShowAgents.Text = "Show Agents";
            this.btnShowAgents.UseVisualStyleBackColor = true;
            this.btnShowAgents.Click += new System.EventHandler(this.btnShowAgents_Click);
            // 
            // btnLoadServiceOrders
            // 
            this.btnLoadServiceOrders.Location = new System.Drawing.Point(230, 200);
            this.btnLoadServiceOrders.Name = "btnLoadServiceOrders";
            this.btnLoadServiceOrders.Size = new System.Drawing.Size(180, 40);
            this.btnLoadServiceOrders.TabIndex = 2;
            this.btnLoadServiceOrders.Text = "Load Service Orders";
            this.btnLoadServiceOrders.UseVisualStyleBackColor = true;
            this.btnLoadServiceOrders.Click += new System.EventHandler(this.btnLoadServiceOrders_Click);
            // 
            // btnShowServiceOrders
            // 
            this.btnShowServiceOrders.Location = new System.Drawing.Point(230, 250);
            this.btnShowServiceOrders.Name = "btnShowServiceOrders";
            this.btnShowServiceOrders.Size = new System.Drawing.Size(180, 40);
            this.btnShowServiceOrders.TabIndex = 3;
            this.btnShowServiceOrders.Text = "Show Service Orders";
            this.btnShowServiceOrders.UseVisualStyleBackColor = true;
            this.btnShowServiceOrders.Click += new System.EventHandler(this.btnShowServiceOrders_Click);
            // 
            // btnDistributeServiceOrders
            // 
            this.btnDistributeServiceOrders.Location = new System.Drawing.Point(230, 300);
            this.btnDistributeServiceOrders.Name = "btnDistributeServiceOrders";
            this.btnDistributeServiceOrders.Size = new System.Drawing.Size(180, 40);
            this.btnDistributeServiceOrders.TabIndex = 4;
            this.btnDistributeServiceOrders.Text = "Distribute Service Orders";
            this.btnDistributeServiceOrders.UseVisualStyleBackColor = true;
            this.btnDistributeServiceOrders.Click += new System.EventHandler(this.btnDistributeServiceOrders_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnDistributeServiceOrders);
            this.Controls.Add(this.btnShowServiceOrders);
            this.Controls.Add(this.btnLoadServiceOrders);
            this.Controls.Add(this.btnShowAgents);
            this.Controls.Add(this.btnLoadAgents);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadAgents;
        private System.Windows.Forms.Button btnShowAgents;
        private System.Windows.Forms.Button btnLoadServiceOrders;
        private System.Windows.Forms.Button btnShowServiceOrders;
        private System.Windows.Forms.Button btnDistributeServiceOrders;
    }
}

