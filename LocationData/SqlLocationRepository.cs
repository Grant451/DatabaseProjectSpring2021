using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using DatabaseProjectSpring2021;
using LocationData.Models;
using LocationData.DataDelegates;


namespace LocationData
{
    public class SqlLocationRepository : ILocationRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlLocationRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Repair CreateRepair(string repName, string laborCost, string status)
        {
            if (repName == null)
            {
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(repName));
            }
            if (laborCost == null)
                throw new ArgumentException("The parameter cannot be negative", nameof(laborCost));
            if (repName == null)
                throw new ArgumentException("The parameter cannot be negative", nameof(repName));
            if (status == null)
                throw new ArgumentException("The parameter cannot be negative", nameof(status));
            var d = new CreateRepairDataDelegate(repName, laborCost, status);
            return executor.ExecuteNonQuery(d);
        }

        public Appointment CreateAppointment(string streetAddress, string repName, string custName, DateTime dateTime)
        {
            if(dateTime == null)
            {
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(dateTime));
            }
            if (streetAddress == null)
                throw new ArgumentException("The parameter cannot be negative", nameof(streetAddress));
            if (repName == null)
                throw new ArgumentException("The parameter cannot be negative", nameof(repName));
            if (custName == null)
                throw new ArgumentException("The parameter cannot be negative", nameof(custName));
            var d = new CreateAppointmentDataDelegate(streetAddress, repName, custName, dateTime);
            return executor.ExecuteNonQuery(d);
        }

        public Customer CreateCustomer(string customerName, string vinNumber)
        {
            if (string.IsNullOrWhiteSpace(customerName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(customerName));
            if (string.IsNullOrWhiteSpace(vinNumber))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(vinNumber));
            var d = new CreateCustomerDataDelegate(customerName, vinNumber);
            return executor.ExecuteNonQuery(d);
        }

        public Location CreateLocation(string StreetAddress, string City, string Region, string Zip)
        {
            if (string.IsNullOrWhiteSpace(StreetAddress))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(StreetAddress));
            if (string.IsNullOrWhiteSpace(City))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(City));
            if (string.IsNullOrWhiteSpace(Region))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Region));
            if (string.IsNullOrWhiteSpace(Zip))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Zip));
            var d = new CreateLocationDataDelegate(StreetAddress, City, Region, Zip);
            return executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<EmployeeRepair> FetchAllEmployeeRepairCounts(int blank)
        {
            var d = new FetchAllEmployeeRepairCountsDataDelegate(blank);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<EmployeeRepair> FetchEmployeeRepairCounts(string empName)
        {
            var d = new FetchEmployeeRepairCountsDataDelegate(empName);
            return executor.ExecuteReader(d);
        }

        public Location FetchLocation(int LocationID)
        {
            var d = new FetchLocationDataDelegate(LocationID);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<PartSearch> FetchPartInformation(string partName)
        {
            return executor.ExecuteReader(new FetchPartInformationDataDelegate(partName));
        }

        public IReadOnlyList<RepairHistory> FetchRepairHistoryCustomer(string custname)
        {
            var d = new FetchRepairHistoryDataDelegate(custname);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<LocationQuantity> FetchPart(string partName)
        {
            var d = new FetchPartDataDelegate(partName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<RepairHistory> FetchRepairHistoryEmployee(string empName)
        {
            var d = new FetchRepairHistoryEmployeeDataDelegate(empName);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<RepairHistory> FetchRepairHistoryVehicle(string vin)
        {
            var d = new FetchRepairHistoryVehicleDataDelegate(vin);
            return executor.ExecuteReader(d);
        }

        public Location GetLocation(string email)
        {
            var d = new GetLocationDataDelegate(email);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Appointment> RetreiveAppointments()
        {
            return executor.ExecuteReader(new RetrieveAppointmentsDataDelegate());
        }

        public IReadOnlyList<Customer> RetrieveCustomers()
        {
            return executor.ExecuteReader(new RetrieveCustomersDataDelegate());
        }

        public IReadOnlyList<Location> RetrieveLocations()
        {
            return executor.ExecuteReader(new RetrieveLocationsDataDelegate());
        }

        public IReadOnlyList<Repair> RetrieveRepairs()
        {
            return executor.ExecuteReader(new RetrieveRepairsDataDelegate());
        }

        public IReadOnlyList<PartSearch> FetchRepairParts(string repairName)
        {
            return executor.ExecuteReader(new FetchRepairPartsDataDelegate(repairName));
        }

        public IReadOnlyList<EmployeeLocation> FetchEmployeeLocation(string felemname)
        {
            return executor.ExecuteReader(new FetchEmployeeLocationDataDelegate(felemname));
        }

        public IReadOnlyList<SalesObj> FetchSalesSpecific(string streetAddress)
        {
            return executor.ExecuteReader(new FetchSalesSpecificDataDelegate(streetAddress));
        }

        public IReadOnlyList<SalesObj> FetchSales(int blank)
        {
            return executor.ExecuteReader(new FetchSalesDataDelegate(blank));
        }

        public IReadOnlyList<SalesObj> FetchAllLocationsAddress(int blank)
        {
            return executor.ExecuteReader(new FetchAllLocationsAddressDataDelegate(blank));
        }

        public IReadOnlyList<PartSearch> FetchInventorySpecific(string streetAddress)
        {
            return executor.ExecuteReader(new FetchInventorySpecificDataDelegate(streetAddress));
        }

        public IReadOnlyList<PartSearch> FetchInventory(int blank)
        {
            return executor.ExecuteReader(new FetchInventoryDataDelegate(blank));
        }

        public IReadOnlyList<PopularApptTimes> FetchPopularApptTimes(int blank)
        {
            return executor.ExecuteReader(new FetchPopularApptTimesDataDelegate(blank));
        }

        public IReadOnlyList<EmployeeRepair> FetchAllEmployees(int blank)
        {
            return executor.ExecuteReader(new FetchAllEmployeesDataDelegate(blank));
        }

        public IReadOnlyList<RepairHistory> FetchRepeatRepairsSpecific(string custName)
        {
            return executor.ExecuteReader(new FetchRepeatRepairsSpecificDataDelegate(custName));
        }

        public IReadOnlyList<RepairHistory> FetchRepeatRepairs(int blank)
        {
            return executor.ExecuteReader(new FetchRepeatRepairsDataDelegate(blank));
        }

        public IReadOnlyList<RepairHistory> FetchReparsinProgress(string streetAddress)
        {
            return executor.ExecuteReader(new FetchReparsinProgressDataDelegate(streetAddress));
        }

        public IReadOnlyList<SalesObj> FetchSalesPerYear(int blank6)
        {
            return executor.ExecuteReader(new FetchSalesPerYearDataDelegate(blank6));
        }

        public IReadOnlyList<RepairHistory> FetchCustomerReport(string fcrempName)
        {
            return executor.ExecuteReader(new FetchCustomerReportDataDelegate(fcrempName));
        }

        public IReadOnlyList<RepairHistory> FetchVinReport(string fvrvin)
        {
            return executor.ExecuteReader(new FetchVinReportDataDelegate(fvrvin));
        }

        public IReadOnlyList<HourReport> FetchEmployeesByHours(string febhempName)
        {
            return executor.ExecuteReader(new FetchEmployeesByHoursDataDelegate(febhempName));
        }

        
    }
}
