using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairDistribution
{
    class Service
    {
        public string Code { get; set; }
        public string Service_Name { get; set; }
        public int Duration { get; set; }
        public int Commission { get; set; }

        public Service (string Code, string Service_Name, int Duration, int Commission)
        {
            this.Code = Code;
            this.Service_Name = Service_Name;
            this.Duration = Duration;
            this.Commission = Commission;
        }
    }
}
