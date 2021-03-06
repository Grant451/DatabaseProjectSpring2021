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
        AppointmentID int Not NUll identity(1,1),
        LocationID int not null,
        RepairID int not null,
        CustomerID int not null,
        AppointmentTime Datetime2(0) not null
        */

        public int AppointmentID { get; }
        
        public int LocationID { get; }

        public int RepairID { get; }

        public int CustomerID { get; }

        public DateTime AppointmentTime { get; }

        public string StreetAddress { get; }
        public string RepairName { get; }
        public string CustomerName { get; }

        //q1 constructor for creating an apointment: 
        //StreetAddress, RepairName, CustomerName, AppointmentTime
        public Appointment(string streetAddress, string repairName, string customerName,   DateTime appointmentTime)
        {
            StreetAddress = streetAddress;
            RepairName = repairName;
            CustomerName = customerName;
            AppointmentTime = appointmentTime;
        }

        public Appointment(int appointmentID, int customerID, int locationID, int repairID, DateTime appointmentTime)
        {
            AppointmentID = appointmentID;
            CustomerID = customerID;
            LocationID = locationID;
            RepairID = repairID;
            AppointmentTime = appointmentTime;
        }

    }
}
