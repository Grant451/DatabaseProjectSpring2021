using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class RepairHistory
    {
        public string CustomerName { get; }

        public string RepairName { get; }

        //public string VinNumber { get; }

        public RepairHistory(string customerName, string repairName)
        {
            CustomerName = customerName;
            RepairName = repairName;
        }

        public RepairHistory(string vinNumber, string customerName, string repairName)
        {
            CustomerName = customerName;
            RepairName = repairName;
            //VinNumber = vinNumber;
        }
    }
}
