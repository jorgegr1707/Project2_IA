using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairDistribution
{
    class Order
    {
        public int ID { get; set; }
        public string Client { get; set; }
        public string ServiceCode { get; set; }

        public Order(int ID, string Client, string ServiceCode)
        {
            this.ID = ID;
            this.Client = Client;
            this.ServiceCode = ServiceCode;
        }
    }
}
