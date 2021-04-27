using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class Repair
    {
        public int RepairID { get; }

        public string RepairName { get; }

        public string LaborCost { get; }

        public string Status { get; }

        public Repair(string RepName, string laborCost, string status)
        {
            RepairName = RepName;
            LaborCost = laborCost;
            Status = status;
        }

        public Repair(int repair, string repairName, string laborCost, string status)
        {
            RepairID = repair;
            RepairName = repairName;
            LaborCost = laborCost;
            Status = status;
        }
    }
}
