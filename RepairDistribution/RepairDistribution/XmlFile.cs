using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RepairDistribution
{
    class XmlFile
    {
        XDocument docAgents;      /*Document of agents*/
        XDocument docOrders;      /*Document of orders*/
        public ArrayList dataAgents;    /*Array of agents information (ID, name, service codes)*/
        public ArrayList dataOrders;    /*Array of orders information(ID, client, service code)*/

        public XmlFile()
        {
            dataAgents = new ArrayList();
            dataOrders = new ArrayList();
        }
        
        /************************************************
         *Functions that creates the XML, this functions*
         *save the file inside the project.             *
         *Parameters:                                   *
         *      path: string that contains the path of  *
         *              the file to cosult.             *
         ************************************************/
        public void CreateXmlAgents(string path)
        {
            LoadXmlAgents(path);
            docAgents.Save(Environment.CurrentDirectory + "\\data_agents.xml");
        }

        public void CreateXmlOrders(string path)
        {
            LoadXmlOrders(path);
            docOrders.Save(Environment.CurrentDirectory + "\\data_orders.xml");
        }


        /************************************************
         *Functions that load a XML file.               *
         *Parameters:                                   *
         *      path: string that contains the path of  *
         *              the file to cosult.             *
         ************************************************/
        public void LoadXmlAgents(string path)
        {
            docAgents = XDocument.Load(path);
        }

        public void LoadXmlOrders(string path)
        {
            docOrders = XDocument.Load(path);
        }

        /************************************************
         *Functions that read the XML file and store da-*
         *ta of every agent in an array.                *
         ************************************************/
        public void ReadXmlAgents()
        {

            /*Get each agent of the file*/
            foreach(XElement element in docAgents.Descendants("agent"))
            {

                /*Get ID and name of agent*/
                ArrayList dataAgent = new ArrayList
                {
                    element.Element("id").Value,
                    element.Element("name").Value
                };

                /*Get each code of services of agent*/
                foreach (XElement code in element.Descendants("code"))
                {
                    dataAgent.Add(code.Value);
                }
                dataAgents.Add(dataAgent);

                /*Debug part*/
                foreach (string da in dataAgent)
                {
                    Console.WriteLine(da);
                }
                /*End Debug part*/
            }
        }

        public void ReadXmlOrders()
        {
            /* Get each order of the file */
            foreach (XElement element in docOrders.Descendants("order"))
            {
                /* Get ID, client and service code */
                ArrayList dataOrder = new ArrayList
                {
                    element.Element("id").Value,
                    element.Element("client").Value,
                    element.Element("service").Value
                };
                dataOrders.Add(dataOrder);
            }
        }


        /************************************************
         *Functions that returns an array (agents or    *
         * services)                                    *
         *Returns:                                      *
         *      Array-list (agents or services)         *
         ************************************************/
        public ArrayList GetAgents()
        {
            ArrayList agents = new ArrayList();

            /*Get data of each agent in array*/
            foreach(ArrayList dataAgent in dataAgents)
            {

                /*Get ID and name, also creates agent*/
                Agent agent;
                int ID = Int32.Parse(dataAgent[0].ToString());
                string name = dataAgent[1].ToString();

                agent = new Agent(ID, name);

                /*Add each service to agent*/
                for(int i = 2; i < dataAgent.Count; i++)
                {
                    agent.AddCode(dataAgent[i].ToString());
                }
                agents.Add(agent);
                
            }

            /*Debug part*/
            foreach (Agent a in agents)
            {
                Console.WriteLine(a.ID);
                Console.WriteLine(a.Name);
                foreach (string code in a.ServiceCodes)
                {
                    Console.WriteLine(code);
                }
            }
            /*End Debug part*/
            return agents;
        }

        public ArrayList GetOrders()
        {
            ArrayList orders = new ArrayList();

            /* Get data of order */
            foreach(ArrayList dataOrder in dataOrders)
            {
                Order order;

                int ID = Int32.Parse(dataOrder[0].ToString());
                string client = dataOrder[1].ToString();
                string code = dataOrder[2].ToString();

                /* Create order and add it in array orders*/
                order = new Order(ID, client, code);
                orders.Add(order);
            }

            /* Debug part */
            foreach(Order order in orders)
            {
                Console.WriteLine(order.ID);
                Console.WriteLine(order.Client);
                Console.WriteLine(order.ServiceCode);
            }
            /* End Debug part*/
            return orders;
        }
    }
}
