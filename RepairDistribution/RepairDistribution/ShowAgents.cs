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
	public partial class ShowAgents : Form
	{
		Controller controller = Controller.GetInstance();
		public ShowAgents()
		{
			InitializeComponent();
			LoadAgentsDataGridView(); 
		}

		public void LoadAgentsDataGridView()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("ID");
			dt.Columns.Add("Name");
			dt.Columns.Add("Services code");
			
			foreach (Agent a in controller.agents)
			{
				var result = string.Join(",", a.ServiceCodes.ToArray()
					.Select(o => o.ToString()).ToArray());
				dt.Rows.Add(new object[] { a.ID, a.Name, result});
			}
			dataGridView1.DataSource = dt;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ShowAgents_Load(object sender, EventArgs e)
		{

		}
	}
}
