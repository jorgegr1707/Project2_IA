using System;
using System.Collections;
using System.Collections.Generic;
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

            /*Prueba crear poblacion inicial*/
            genAlgorithm = new GeneticAlgorithm(agents, orders, services);
            genAlgorithm.generate_population();

            /*Prueba obtener comisiones*/
            //List<int> commissions = genAlgorithm.commission_agents(genAlgorithm.population[4]);
            genAlgorithm.calculate_fitness();
            

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
                Console.WriteLine(orders.Count);
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
