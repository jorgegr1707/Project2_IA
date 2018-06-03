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
		private VoiceAgent agent = VoiceAgent.Instance;
		public Form1()
        {
            InitializeComponent();
			init1.Show(); 
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.Hide(); 
			showServices1.Hide();
			distribute1.Hide(); 

        }

        private void btnLoadAgents_Click(object sender, EventArgs e)
        {
			init1.Hide();
			loadAgentsUC.Show();
			loadServices1.Hide();
			showAgents1.Hide();
			showServices1.Hide();
			distribute1.Hide();
		}

        private void btnShowAgents_Click(object sender, EventArgs e)
        {
			init1.Hide();
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.LoadAgentsDataGridView();
			showAgents1.Show();
			showServices1.Hide();
			distribute1.Hide();
		}

        private void btnLoadServiceOrders_Click(object sender, EventArgs e)
        {
			init1.Hide();
			loadAgentsUC.Hide();
			loadServices1.Show();
			showAgents1.Hide();
			showServices1.Hide();
			distribute1.Hide();
		}

        private void btnShowServiceOrders_Click(object sender, EventArgs e)
        {
			init1.Hide();
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.Hide();
			showServices1.LoadServicesDataGridView(); 
			showServices1.Show();
			distribute1.Hide();
		}

        private void btnDistributeServiceOrders_Click(object sender, EventArgs e)
        {
			init1.Hide();
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.Hide();
			showServices1.Hide();
			distribute1.Show();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//setting voice recognition and synthesis 
			Timer timer = new Timer();
			timer.Interval = 1;
		

			timer.Tick += delegate (object s, EventArgs ee)
			{
				((Timer)s).Stop();
				try
				{
					agent.synthesizer.Speak("Welcome to smart");
				}
				catch
				{

				}
			};
		}

		private void panel_image_Paint(object sender, PaintEventArgs e)
		{

		}

		private void distribute1_Load(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			init1.Show();
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.Hide();
			showServices1.Hide();
			distribute1.Hide();

		}

		private void init1_Load(object sender, EventArgs e)
		{

		}
	}
}
