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
        XDocument doc;      /*Document of agents*/
        public ArrayList dataAgents;    /*Array of agents information (ID, name, service codes)*/

        public XmlFile()
        {
            dataAgents = new ArrayList();
        }
        
        /************************************************
         *Function that creates the XML, this function  *
         *saves the file inside the project.            *
         *Parameters:                                   *
         *      path: string that contains the path of  *
         *              the file to cosult.             *
         ************************************************/
        public void CreateXml(string path)
        {
            LoadXml(path);
            doc.Save(Environment.CurrentDirectory + "\\data_agents.xml");
        }


        /************************************************
         *Function that load a XML file.                *
         *Parameters:                                   *
         *      path: string that contains the path of  *
         *              the file to cosult.             *
         ************************************************/
        public void LoadXml(string path)
        {
            doc = XDocument.Load(path);
        }

        /************************************************
         *Function that read the XML file and store data*
         *of every agent in an array.                   *
         ************************************************/
        public void ReadXml()
        {

            /*Get each agent of the file*/
            foreach(XElement element in doc.Descendants("agent"))
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


        /************************************************
         *Function that returns all the agents of the   *
         *array.                                        *
         *Returns:                                      *
         *      Array-list of agents                    *
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
    }
}
