using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepairDistribution
{
    public class Controller
    {
        GeneticAlgorithm genAlgorithm;
        public ArrayList agents;
        public ArrayList orders;
        public ArrayList services;
        private XmlFile xmlFile;
        private static Controller controller = null;

        private Controller()
        {
            xmlFile = new XmlFile();
            LoadXmlAgents();
            LoadXmlOrders();
            LoadServices();           
        }

		public List<DataTable> RunGenetic() {
			genAlgorithm = new GeneticAlgorithm(agents, orders, services);
			List<Agent> solution = genAlgorithm.get_solution();
			List<List<int>> com = genAlgorithm.commission_and_hours_agents(solution);
			Console.WriteLine("____________BEST GEN___________");
			DataTable dt1 = new DataTable();
			dt1.Columns.Add("Order ID");
			dt1.Columns.Add("Client");
			dt1.Columns.Add("Requested Service");
			dt1.Columns.Add("Assigned Agent");
			for (int i = 0; i < solution.Count; i++)
			{
				Agent agent = (Agent)solution[i];
				Order order = (Order)orders[i];
				if (agent == null)
				{
					Console.WriteLine("No agent available for this order");
					dt1.Rows.Add(new object[] { order.ID.ToString(), order.Client, order.ServiceCode, "No Agent" });
				}
				else
				{
					Console.WriteLine(agent.Name);
					dt1.Rows.Add(new object[] { order.ID.ToString(), order.Client, order.ServiceCode, agent.Name });
				}
				
				
			}
			Console.WriteLine("----Debug----");
			DataTable dt = new DataTable();
			dt.Columns.Add("Agent Name");
			dt.Columns.Add("Comission");
			dt.Columns.Add("Working hours");
			for (int j = 0; j < agents.Count; j++)
			{
				Agent agent = (Agent)agents[j];
				List<int> comi = com[0];
				List<int> hours = com[1];
				Console.WriteLine(agent.Name + " " + comi[j] + " " + hours[j]);
				dt.Rows.Add(new object[] { agent.Name, comi[j].ToString(), hours[j].ToString() });
			}
			List<DataTable> dts = new List<DataTable>();
			dts.Add(dt1);
			dts.Add(dt); 
			return dts; 

		}
		/*Singleton part xd*/
		public static Controller GetInstance()
        {
            if(controller == null)
            {
                controller = new Controller();
            }
            return controller;
        }

        /*Load XML file*/
        public void LoadXmlAgents()
        {
            try
            {
                xmlFile.LoadXmlAgents(Environment.CurrentDirectory + "\\data_agents.xml");
                xmlFile.ReadXmlAgents();
                agents = xmlFile.GetAgents();
            }
            catch(Exception)
            { }
        }

        public void LoadXmlOrders()
        {
            try
            {	
				xmlFile.LoadXmlOrders(Environment.CurrentDirectory + "\\data_orders.xml");
                xmlFile.ReadXmlOrders();
                orders = xmlFile.GetOrders();
			}
            catch(Exception)
            { }
        }

        public void LoadServices()
        {
            services = new ArrayList();
            services.Add(new Service("ICE", "Instalación de Cocina Eléctrica", 2, 250));
            services.Add(new Service("ICG", "Instalación de Cocina de Gas", 4, 400));
            services.Add(new Service("ILA", "Instalación de Lavadora Automática", 1, 200));
            services.Add(new Service("RCE", "Reparación de Cocina Eléctrica", 4, 300));
            services.Add(new Service("RCG", "Reparación de Cocina de Gas", 6, 500));
            services.Add(new Service("RLA", "Reparación de Lavadora Automática", 6, 250));
        }

        /*Create XML, save it in project's directory*/
        public void CreateXmlAgents(string path)
        {
            xmlFile.CreateXmlAgents(path);
            LoadXmlAgents();
        }

        public void CreateXmlOrders(string path)
        {
            xmlFile.CreateXmlOrders(path);
            LoadXmlOrders();
        }
    }
}
