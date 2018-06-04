using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace RepairDistribution
{
    public partial class Form1 : Form
    {
        Controller controller = Controller.GetInstance();
		private VoiceAgent agent = VoiceAgent.Instance;
		private SpeechRecognitionEngine listener = new SpeechRecognitionEngine();
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
			List<DataTable> dts = controller.RunGenetic();
			init1.Hide();
			loadAgentsUC.Hide();
			loadServices1.Hide();
			showAgents1.Hide();
			showServices1.Hide();
			distribute1.LoadAgentsDataGridView(dts); 
			distribute1.Show();
		}

		public void reader(object sender, SpeechRecognizedEventArgs e)
		{
			if (e.Result.Confidence < 0.30)
			{
				agent.synthesizer.Speak("Sorry I didn't understood, can you repeat?");
				Console.WriteLine("result: " + e.Result.Text);
				return;
			};
			
			Console.WriteLine("result: " + e.Result.Text);
			if (e.Result.Text == "Load Agents")
			{
				agent.synthesizer.Speak("Loading Agents from Default File: Data Agents XML");
				
			}
			else if (e.Result.Text == "Load Orders")
			{
				agent.synthesizer.Speak("Loading Orders of Services from Default File: Data Orders XML");
			}
			else if (e.Result.Text == "Show Agents")
			{
				agent.synthesizer.Speak("Showing the agents");
				init1.Hide();
				loadAgentsUC.Hide();
				loadServices1.Hide();
				showAgents1.LoadAgentsDataGridView();
				showAgents1.Show();
				showServices1.Hide();
				distribute1.Hide();
			}
			else if (e.Result.Text == "Show Orders")
			{
				agent.synthesizer.Speak("Showing the services orders");
				init1.Hide();
				loadAgentsUC.Hide();
				loadServices1.Hide();
				showAgents1.Hide();
				showServices1.LoadServicesDataGridView();
				showServices1.Show();
				distribute1.Hide();
			} 
			else if (e.Result.Text == "Assign")
			{
				agent.synthesizer.Speak("Distribution of Services and Agents");
				List<DataTable> dts = controller.RunGenetic();
				init1.Hide();
				loadAgentsUC.Hide();
				loadServices1.Hide();
				showAgents1.Hide();
				showServices1.Hide();
				distribute1.LoadAgentsDataGridView(dts);
				distribute1.Show();
			}
			else if (e.Result.Text == "Exit" || e.Result.Text == "Bye")
			{
				agent.synthesizer.Speak("Get Back Soon!");
				this.Close();
				Application.Exit();
			}
			else
			{
				agent.synthesizer.Speak("Sorry I didn't understood, can you repeat?");
			}
			
		}



		private void Form1_Load(object sender, EventArgs e)
		{
			//setting voice recognition and synthesis 
			Timer timer = new Timer();
			timer.Interval = 1;

			Console.WriteLine("1");

			timer.Tick += delegate (object s, EventArgs ee)
			{
				((Timer)s).Stop();
				try
				{
					agent.synthesizer.Speak("Welcome to smart, Show Service");
					CultureInfo ci = new CultureInfo("en-EN");
					agent.setListener(new SpeechRecognitionEngine(ci));
					listener = agent.getListener();
					Choices comandoIniciar = new Choices();
					comandoIniciar.Add("Load Agents");
					comandoIniciar.Add("Load Orders");
					comandoIniciar.Add("Show Agents");
					comandoIniciar.Add("Show Orders");
					comandoIniciar.Add("Assign");
					comandoIniciar.Add("Exit");
					comandoIniciar.Add("Bye");
					var diccionario = new GrammarBuilder(comandoIniciar);
					var gramatica = new Grammar(diccionario);
					listener.LoadGrammar(gramatica);
					listener.SetInputToDefaultAudioDevice();
					listener.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reader);
					listener.RecognizeAsync(RecognizeMode.Multiple);
				}
				catch (InvalidOperationException)
				{
					MessageBox.Show("It can't be initialized");
				}
			};
			timer.Start();
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
