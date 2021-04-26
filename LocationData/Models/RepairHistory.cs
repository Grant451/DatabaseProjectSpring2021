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

        public string VinNumber { get; }

        public string EmployeeName { get; }

        public int RepeatRepairs { get; }

        public int TimesRepaired { get; }

        public int CustomerID { get; }

        public int RepairID { get; }

        //constructor for q24
        public RepairHistory(int customerID, string customerName, int repairID, string vinNumber)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            RepairID = repairID;
            VinNumber = vinNumber;
        }

        //constructor for q14
        public RepairHistory(string repName, string empName, string custName)
        {
            EmployeeName = empName;
            CustomerName = custName;
            RepairName = repName;
        }

        //constructor for q20
        //public RepairHistory(string empName, string custName, string repName, int timesRepaired)
        public RepairHistory(string custName, string repName, int timesRepaired)
        {
            //EmployeeName = empName;
            CustomerName = custName;
            RepairName = repName;
            TimesRepaired = timesRepaired;
        }

        //constructor for q19:
        //public RepairHistory(string empName, string repName, int reprepairs)
        public RepairHistory(string repName, int reprepairs)
        {
            //EmployeeName = empName;
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
