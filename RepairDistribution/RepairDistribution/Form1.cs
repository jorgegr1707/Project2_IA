using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairDistribution
{
    public partial class Form1 : Form
    {
        Controller controller = Controller.GetInstance();
        public Form1()
        {
            InitializeComponent();
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.Hide(); 
			showServices1.Hide();
			distribute1.Hide(); 

        }

        private void btnLoadAgents_Click(object sender, EventArgs e)
        {
			loadAgentsUC.Show();
			loadServices1.Hide();
			showAgents1.Hide();
			showServices1.Hide();
			distribute1.Hide();
		}

        private void btnShowAgents_Click(object sender, EventArgs e)
        {
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.Show();
			showAgents1.LoadAgentsDataGridView(); 
			showServices1.Hide();
			distribute1.Hide();
		}

        private void btnLoadServiceOrders_Click(object sender, EventArgs e)
        {
			loadAgentsUC.Hide();
			loadServices1.Show();
			showAgents1.Hide();
			showServices1.Hide();
			distribute1.Hide();
		}

        private void btnShowServiceOrders_Click(object sender, EventArgs e)
        {
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.Hide();
			showServices1.Show();
			distribute1.Hide();
		}

        private void btnDistributeServiceOrders_Click(object sender, EventArgs e)
        {
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.Hide();
			showServices1.Hide();
			distribute1.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void panel_image_Paint(object sender, PaintEventArgs e)
		{

		}

		private void distribute1_Load(object sender, EventArgs e)
		{

		}



		/*private void btn_openfile_Click(object sender, EventArgs e)
        {
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string extension;

                extension = Path.GetExtension(ofd.FileName);

                if(extension.Equals(".xml"))
                {
                    
                }
                txt_filename.Text = ofd.SafeFileName;
                txt_filepath.Text = ofd.FileName;
                XmlFile xmlFile = new XmlFile(ofd.FileName);
                xmlFile.ReadXml();

            }
        }*/
	}
}
