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
        //string PathXml;
        XDocument doc;
        public ArrayList dataAgents;

        public XmlFile()
        {
            dataAgents = new ArrayList();
        }

        public void CreateXml(string path)
        {
            LoadXml(path);
            doc.Save(Environment.CurrentDirectory + "\\data_agents.xml");
        }

        public void LoadXml(string path)
        {
            doc = XDocument.Load(path);
        }

        public void ReadXml()
        {
            foreach(XElement element in doc.Descendants("agent"))
            {
                ArrayList dataAgent = new ArrayList
                {
                    element.Element("id").Value,
                    element.Element("name").Value
                };

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
            }
        }

        public ArrayList GetAgents()
        {
            ArrayList agents = new ArrayList();
            Console.WriteLine("Llega");
            foreach(ArrayList dataAgent in dataAgents)
            {
                Agent agent;
                int ID = Int32.Parse(dataAgent[0].ToString());
                string name = dataAgent[1].ToString();

                agent = new Agent(ID, name);
                for(int i = 2; i < dataAgent.Count; i++)
                {
                    agent.AddCode(dataAgent[i].ToString());
                }
                agents.Add(agent);
                
            }
            foreach (Agent a in agents)
            {
                Console.WriteLine(a.ID);
                Console.WriteLine(a.Name);
                foreach (string code in a.ServiceCodes)
                {
                    Console.WriteLine(code);
                }
            }
            return agents;
        }
    }
}
