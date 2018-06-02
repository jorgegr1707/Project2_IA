using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;



namespace RepairDistribution.UserControls
{
	public partial class ShowAgents : UserControl
	{
		Controller controller = Controller.GetInstance();
		public ShowAgents()
		{
			InitializeComponent();
			dataGridView1.EnableHeadersVisualStyles = false;
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
				dt.Rows.Add(new object[] { a.ID, a.Name, result });
			}
			if (dataGridView1.DataSource != null) {
				Console.WriteLine("al menos entra aca> ?"); 
				dataGridView1.DataSource = null;
				dataGridView1.Rows.Clear(); 
			}
			dataGridView1.DataSource = dt;
		}

		private void LoadAgents_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
