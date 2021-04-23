using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class Appointment
    {
        /*
        CustomerID int identity,
        LocationID int,
        RepairID int,
        Datetime Datetime2
        */

        public int CustomerID { get; }
        
        public int LocationID { get; }

        public int RepairID { get; }

        public DateTime DateTime { get; }

        public Appointment(int customerID, int locationID, int repairID, DateTime dateTime)
        {
            CustomerID = customerID;
            LocationID = locationID;
            RepairID = repairID;
            DateTime = dateTime;
        }
    }
}
