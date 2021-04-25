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

        public string EmployeeName { get; }

        public int RepeatRepairs { get; }

        public int TimesRepaired { get; }

        //constructor for q14
        public RepairHistory(string repName, string empName, string custName)
        {
            EmployeeName = empName;
            CustomerName = custName;
            RepairName = repName;
        }

        //constructor for q20
        public RepairHistory(string empName, string custName, string repName, int timesRepaired)
        {
            EmployeeName = empName;
            CustomerName = custName;
            RepairName = repName;
            TimesRepaired = timesRepaired;
        }

        //constructor for q19:
        public RepairHistory(string empName, string repName, int reprepairs)
        {
            EmployeeName = empName;
            RepairName = repName;
            RepeatRepairs = reprepairs;
        }

        public RepairHistory(string customerName, string repairName)
        {
            CustomerName = customerName;
            RepairName = repairName;
        }

        /*
        public RepairHistory(string vinNumber, string customerName, string repairName)
        {
            CustomerName = customerName;
            RepairName = repairName;
            //VinNumber = vinNumber;
        }
        */
    }
}
