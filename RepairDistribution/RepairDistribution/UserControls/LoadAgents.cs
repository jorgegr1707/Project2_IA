using System;
using System.Windows.Forms;
using System.IO;

namespace RepairDistribution.UserControls
{
	public partial class LoadAgents : UserControl
	{
		Controller controller = Controller.GetInstance();
		OpenFileDialog ofd = new OpenFileDialog();

		public LoadAgents()
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

			//Verify if extension is correct
			if (extension.Equals(".xml"))
			{
				controller.CreateXmlAgents(path);
			}
			
		}

	}
}
