using System;
using System.Collections.Generic;
using LocationData.Models;

namespace LocationData
{
    public interface ILocationRepository
    {
        //location services:
        IReadOnlyList<Location> RetrieveLocations();
        Location FetchLocation(int LocationID);
        Location GetLocation(string email);
        Location CreateLocation(string streetAddress, string city, string region, string zip);

        //appointment services:
        Appointment CreateAppointment(int locationID, int repairID, int customerID, DateTime appointmentTime);
        IReadOnlyList<Appointment> RetreiveAppointments();

        //Customer services:
        Customer CreateCustomer(string customerName, string vinNumber);
        IReadOnlyList<Customer> RetrieveCustomers();

        //repair history query 2:
        IReadOnlyList<Repair> RetrieveRepairs();
        RepairHistory FetchRepairHistoryCustomer(string custname);
    }
}
