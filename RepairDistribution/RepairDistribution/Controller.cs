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
        private XmlFile xmlFile;
        private static Controller controller = null;

        private Controller()
        {
            xmlFile = new XmlFile();
            LoadXml();
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
        public void LoadXml()
        {
            try
            {
                xmlFile.LoadXml(Environment.CurrentDirectory + "\\data_agents.xml");
                xmlFile.ReadXml();
                agents = xmlFile.GetAgents();
            }
            catch(Exception)
            { }
        }

        /*Create XML, save it in project's directory*/
        public void CreateXml(string path)
        {
            xmlFile.CreateXml(path);
            LoadXml();
        }
    }
}
