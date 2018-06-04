using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RepairDistribution.UserControls
{
	public partial class Distribute : UserControl
	{
		public Distribute()
		{
			InitializeComponent();
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView2.EnableHeadersVisualStyles = false;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		public void LoadAgentsDataGridView(List<DataTable> dts)
		{
			if (dataGridView1.DataSource != null)
			{
				dataGridView1.DataSource = null;
				dataGridView1.Rows.Clear();
			}
			dataGridView1.DataSource = dts[1];

			if (dataGridView2.DataSource != null)
			{
				dataGridView2.DataSource = null;
				dataGridView2.Rows.Clear();
			}
			dataGridView2.DataSource = dts[0];

		}



	}
}
