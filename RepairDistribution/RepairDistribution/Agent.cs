using System.Collections;
using System.Collections.Generic;


namespace RepairDistribution
{
    class Agent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ArrayList ServiceCodes { get; set; }

        public Agent(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
            ServiceCodes = new ArrayList();
        }

        public void AddCode(string code)
        {
            ServiceCodes.Add(code);
        }

		private string getServicesCodes()
		{
			string total = "";
			List<string> codes = new List<string>(); 
			foreach (string code in ServiceCodes)
			{
				codes.Add(code); 
			}
			return total; 
		}
    }
}
