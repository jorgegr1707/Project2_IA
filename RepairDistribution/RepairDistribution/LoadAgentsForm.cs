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
    public partial class LoadAgentsForm : Form
    {

        Controller controller = Controller.GetInstance();
        OpenFileDialog ofd = new OpenFileDialog();

        public LoadAgentsForm()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = ofd.FileName;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            string path, extension;
            path = txtFileName.Text;
            extension = Path.GetExtension(path);

            /*Verify if extension is correct*/
            if(extension.Equals(".xml"))
            {
                controller.CreateXml(path);
            }
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }
    }
}
