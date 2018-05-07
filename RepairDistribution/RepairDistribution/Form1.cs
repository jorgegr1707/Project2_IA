using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairDistribution
{
    public partial class Form1 : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {

            XmlFile xmlFile = new XmlFile("C:/Users/jorge/Desktop/ejemplo.xml");
            xmlFile.ReadXml();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_filename.Text = ofd.SafeFileName;
                txt_filepath.Text = ofd.FileName;

            }
        }
    }
}
