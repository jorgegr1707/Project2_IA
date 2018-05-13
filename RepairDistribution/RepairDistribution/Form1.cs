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
        }

        private void btnLoadAgents_Click(object sender, EventArgs e)
        {
            LoadAgentsForm loadForm = new LoadAgentsForm();
            loadForm.Show();
            Hide();
        }

        private void btnShowAgents_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnLoadServiceOrders_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnShowServiceOrders_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnDistributeServiceOrders_Click(object sender, EventArgs e)
        {
            Hide();
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
