using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class Customer
    {
        public int CustomerID { get; }

        public string CustomerName { get; }

        public string VinNumber { get; }

        internal Customer(int customerID, string customerName, string vinNumber)
        {
            CustomerID = customerID;
            CustomerName = customerName;
            VinNumber = vinNumber;
        }
    }
}
