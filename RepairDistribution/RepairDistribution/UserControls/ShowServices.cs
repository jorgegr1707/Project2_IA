using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairDistribution.UserControls
{
	public partial class ShowServices : UserControl
	{
		Controller controller = Controller.GetInstance();
		public ShowServices()
		{
			InitializeComponent();
			dataGridView1.EnableHeadersVisualStyles = false;
		}

		public void LoadServicesDataGridView()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("ID");
			dt.Columns.Add("Client Name");
			dt.Columns.Add("Required Service Code");

			foreach (Order o in controller.orders)
			{
				dt.Rows.Add(new object[] { o.ID, o.Client, o.ServiceCode });
			}

			if (dataGridView1.DataSource != null)
			{
				Console.WriteLine("al menos entra aca> ?");
				dataGridView1.DataSource = null;
				dataGridView1.Rows.Clear();
			}
			dataGridView1.DataSource = dt;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
