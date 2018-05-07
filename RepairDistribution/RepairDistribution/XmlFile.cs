using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RepairDistribution
{
    class XmlFile
    {
        string PathXml;
        XDocument doc;

        public XmlFile(string path)
        {
            PathXml = path;
            doc = XDocument.Load(path);
        }        

        public void ReadXml()
        {
            foreach(XElement element in doc.Descendants("agent"))
            {
                Console.WriteLine("Id: " + element.Element("id").Value);
                Console.WriteLine("Name: " + element.Element("name").Value);

                foreach(XElement code in element.Descendants("code"))
                {
                    Console.WriteLine("Code: " + code.Value);
                }
            }
        }
    }
}
