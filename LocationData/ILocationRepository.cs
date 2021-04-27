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
        Appointment CreateAppointment(string streetAddress, string repName, string custName, DateTime dateTime);
        IReadOnlyList<Appointment> RetreiveAppointments();

        //Customer services:
        Customer CreateCustomer(string customerName, string vinNumber);
        IReadOnlyList<Customer> RetrieveCustomers();

        //Query 1 Fetch part information:
        IReadOnlyList<PartSearch> FetchPartInformation(string partName);

        //repair history query 2:
        IReadOnlyList<Repair> RetrieveRepairs();
        IReadOnlyList<RepairHistory> FetchRepairHistoryCustomer(string custname);

        //repair history by vin query 3:
        IReadOnlyList<RepairHistory> FetchRepairHistoryVehicle(string vin);

        //repair history by employee query 4:
        IReadOnlyList<RepairHistory> FetchRepairHistoryEmployee(string empName);

        //part quantity accross locations query 5:
        IReadOnlyList<LocationQuantity> FetchPart(string partName);

        //part quantity across locations query 6:
        IReadOnlyList<PartSearch> FetchRepairParts(string repairName);

        //LocationId, StreetAddress, City, Region, Zip query 7:
        IReadOnlyList<EmployeeLocation> FetchEmployeeLocation(string felemname);

        //repair counts by employee query 8:
        IReadOnlyList<EmployeeRepair> FetchEmployeeRepairCounts(string fertest);

        //repair counts for all employees query 9:
        IReadOnlyList<EmployeeRepair> FetchAllEmployeeRepairCounts(int blank);
        
        //sales specific query 10:
        IReadOnlyList<SalesObj> FetchSalesSpecific(string fssstreetAddress);

        //returns total sales across all stores query 11:
        IReadOnlyList<SalesObj> FetchSales(int blank);

        //returns list current inventory at a specific store in reverse order by quantity query 12:
        IReadOnlyList<PartSearch> FetchInventorySpecific(string streetAddress);
        //lists inventory across all stores in reverse order by quantity query 13:
        IReadOnlyList<PartSearch> FetchInventory(int blank);

        //list total repairs completed for a given store query 14:
        IReadOnlyList<RepairHistory> FetchReparsinProgress(string streetAddress);

        //returns FetchAllLocationsAddress query 16:
        IReadOnlyList<SalesObj> FetchAllLocationsAddress(int blank);

        //returns employee name of all employees Query 17:
        IReadOnlyList<EmployeeRepair> FetchAllEmployees(int blank);

        //returns a list of how many times a specific customer comes back for a given repair query 19:
        IReadOnlyList<RepairHistory> FetchRepeatRepairsSpecific(string custName);

        //Returns how many times a repair has been repeated for a customer query 20:
        IReadOnlyList<RepairHistory> FetchRepeatRepairs(int blank);

        //determines the most popular appointment times to come in for repairs query 22:
        IReadOnlyList<PopularApptTimes> FetchPopularApptTimes(int blank);

        //returns a list of all addresses and years that has the sale for each year in it query 23:
        IReadOnlyList<SalesObj> FetchSalesPerYear(int blank6);

        //returns customerid, customername, repairid, vinnumber query 24:
        IReadOnlyList<RepairHistory> FetchCustomerReport(string fcrempName);

        //returns customerid, customername, repairid, vinnumber query 25:
        IReadOnlyList<RepairHistory> FetchVinReport(string fvrvin);
        //returns a list of all the hours and locations an employee works query 26:
        IReadOnlyList<HourReport> FetchEmployeesByHours(string febhempName);
    }
}
