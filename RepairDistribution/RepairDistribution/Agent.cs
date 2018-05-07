using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairDistribution
{
    class Agent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ArrayList ServiceCodes { get; set; }

        public Agent(int ID, string Name, ArrayList ServiceCodes)
        {
            this.ID = ID;
            this.Name = Name;
            this.ServiceCodes = ServiceCodes;
        }
    }
}
