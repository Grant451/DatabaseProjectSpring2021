using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class RepairHistory
    {
        string CustomerName { get; }

        string RepairName { get; }

        public RepairHistory(string customerName, string repairName)
        {
            CustomerName = customerName;
            RepairName = repairName;
        }
    }
}
