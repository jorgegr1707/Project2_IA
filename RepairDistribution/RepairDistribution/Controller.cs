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
