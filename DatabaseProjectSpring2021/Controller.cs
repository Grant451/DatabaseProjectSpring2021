using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocationData.Models;
using DataAccess;
using System.Transactions;
using LocationData;

namespace DatabaseProjectSpring2021
{
    class Controller
    {
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=CIS560;Integrated Security=SSPI;";

        private static string GetTestString() => Guid.NewGuid().ToString("N");

        private ILocationRepository repo;
        private TransactionScope transaction;

        public void SetQueries()
        {
            repo = new SqlLocationRepository(connectionString);
            transaction = new TransactionScope();
        }

        //Exceute Queries Supported in Customer Tab
        //public List<string> CustomerTabQueries(string generalQuery, string specificQuery)
        public string[][] CustomerTabQueries(string generalQuery, string specificQuery, string input)
        {
            string[][] result = new string[2][];

            switch (generalQuery)
            {
                case ("DisplayAllCustomers"):
                    if (specificQuery == "DisplayRepeatedRepairs")
                    {
                        //FetchRepeatedRepairs
                        try
                        {
                            var queryResult = repo.FetchRepeatRepairs(0);
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[3] { "Customer Name", "Repair Name", "Times Repaired" };
                            result[0] = header;

                            for (int i = 0; i < queryResult.Count; i++)
                            {
                                string[] repair = new string[3] { queryResult[i].CustomerName, queryResult[i].RepairName, queryResult[i].TimesRepaired.ToString() };
                                result[i + 1] = repair;
                            }
                        }
                        catch (Exception)
                        {
                            result[1] = new string[1] { "No repeated repairs" };
                        }
                        
                    }
                    else if (specificQuery == "")
                    {
                        //RetrieveCustomers -- fetch all customers
                        try
                        {
                            var queryResult = repo.RetrieveCustomers();
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[3] { "Customer Id", "Customer Name", "Vin Number" };
                            result[0] = header;

                            for (int i = 0; i < queryResult.Count; i++)
                            {
                                string[] customer = new string[3] { queryResult[i].CustomerID.ToString(), queryResult[i].CustomerName, queryResult[i].VinNumber.ToString() };
                                result[i + 1] = customer;

                            }
                        }
                        catch (Exception)
                        {
                            result[1] = new string[1] { "No customers :(" };
                        }
                        
                    }
                    break;

                case ("DisplaySpecificCustomer"):
                    if (specificQuery == "DisplayRepeatedRepairs")
                    {
                        //FetchRepeatedRepairsSpecific --Roth Mullins
                        try
                        {
                            var queryResult = repo.FetchRepeatRepairsSpecific(input);
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[2] { "Repair Name", "Times Repaired" };
                            result[0] = header;

                            for (int i = 0; i < queryResult.Count; i++)
                            {
                                string[] repair = new string[2] { queryResult[i].RepairName, queryResult[i].RepeatRepairs.ToString() };
                                result[i + 1] = repair;

                            }
                        }
                        catch (Exception)
                        {
                            string msg = "No repeated repairs for " + input;
                            result[1] = new string[1] { msg };
                        }
                    }
                    else if (specificQuery == "DisplayPastRepairs")
                    {
                        // FetchRepairHistoryCustomer
                        try
                        {
                            var queryResult = repo.FetchRepairHistoryCustomer(input);
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[2] { "Customer Name", "Repair Name" };
                            result[0] = header;

                            for (int i = 0; i < queryResult.Count; i++)
                            {
                                string[] repair = new string[2] { input, queryResult[i].RepairName };
                                result[i + 1] = repair;
                            }
                        }
                        catch (Exception)
                        {
                            result[1] = new string[1] { "No past repairs for " + input };
                        }
                        
                        
                    }
                    else if (specificQuery == "DisplayUpcomingAppointments")
                    {
                        //FetchUpcomingAppointmentsCustomer **not complete
                        //var queryResult = repo.FetchUpcomingAppointmentsCustomer(input);
                    }
                    else if (specificQuery == "")
                    {
                        //FetchCustomerReport
                        try
                        {
                            var queryResult = repo.FetchCustomerReport(input);
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[3] { "Customer ID", "CustomerName", "Vin Number" };
                            result[0] = header;

                            for (int i = 0; i < queryResult.Count; i++)
                            {
                                string[] repair = new string[3] { queryResult[i].CustomerID.ToString(), queryResult[i].CustomerName, queryResult[i].VinNumber.ToString() };
                                result[i + 1] = repair;
                            }
                        }
                        catch (Exception)
                        {
                            result[1] = new string[1] { "No past repairs for " + input };
                        }
                    }
                    break;

                case ("DisplaySpecificVehicle"):

                    if (specificQuery == "DisplayPastRepairs")
                    {
                        // FetchRepairHistoryVehicle
                        try
                        {
                            var queryResult = repo.FetchRepairHistoryVehicle(input);
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[3] { "Vin Number", "Customer Name", "Repair Name" };
                            result[0] = header;

                            for (int i = 0; i < queryResult.Count; i++)
                            {
                                string[] repair = new string[3] { input, queryResult[i].EmployeeName, queryResult[i].CustomerName };
                                result[i + 1] = repair;
                            }
                        }
                        catch (Exception)
                        {
                            result[1] = new string[1] { "No past repairs for " + input };
                        }


                    }
                    else if (specificQuery == "")
                    {
                        //FetchVinReport returns: CustomerId, CustomerName, RepairId, vinnumber
                        try
                        {
                            var queryResult = repo.FetchVinReport(input);
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[3] { "Customer ID", "CustomerName", "Vin Number" };
                            result[0] = header;

                            for (int i = 0; i < queryResult.Count; i++)
                            {
                                string[] repair = new string[3] { queryResult[i].CustomerID.ToString(), queryResult[i].CustomerName, queryResult[i].VinNumber.ToString() };
                                result[i + 1] = repair;
                            }
                        }
                        catch (Exception)
                        {
                            result[1] = new string[1] { "No past repairs for " + input };
                        }
                    }
                    break;
            }
            return result;
        }
        
        public string[][] EmployeeTabQueries(string generalQuery, string specificQuery, string input)
        {
            string[][] result = new string[2][];

            switch (generalQuery)
            {
                case ("DisplayAllEmployees"):
                    switch (specificQuery)
                    {
                        case ("DisplayPastRepairs"):
                            //FetchAllRepairHistoryEmployee **not complete
                            break;
                        case ("DisplayRepairCounts"):
                            //FetchAllEmployeeRepairCounts
                            try
                            {
                                var queryResult = repo.FetchAllEmployeeRepairCounts(0);
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[3] { "Employee Name", "Number Of Repairs Completed", "Number Of Repairs In Progress" };
                                result[0] = header;

                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string[] repair = new string[3] { queryResult[i].EmployeeName.ToString(), queryResult[i].RepairsCompleted.ToString(), queryResult[i].RepairsInProgress.ToString() };
                                    result[i + 1] = repair;
                                    //Console.WriteLine(repair);
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No repairs completed or in progress" });
                            }
                            break;
                        case ("DisplayLocation"):
                            //FetchAllEmployeeLocation **not complete
                            break;
                        case (""):
                            //FetchAllEmployees
                            try
                            {
                                var queryResult = repo.FetchAllEmployees(0);
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[1] { "Employee Name" };
                                result[0] = header;

                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string[] repair = new string[1] { queryResult[i].EmployeeName };
                                    result[i + 1] = repair;
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No employees to display" });
                            }
                            break;
                    }
                    break;
                case ("DisplaySpecificEmployee"):
                    switch (specificQuery)
                    {
                        case ("DisplayPastRepairs"):
                            //FetchRepairHistoryEmployee
                            try
                            {
                                var queryResult = repo.FetchRepairHistoryEmployee(input);
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[2] { "Employee Name", "Repair Name" };
                                result[0] = header;


                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string[] repair = new string[2] { input, queryResult[i].RepairName };
                                    result[i + 1] = repair;
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No past repairs for " + input });
                            }
                            break;
                        case ("DisplayRepairCounts"):
                            //FetchEmployeeRepairCounts
                            try
                            {
                                var queryResult = repo.FetchEmployeeRepairCounts(input);
                                if(queryResult == null)
                                {
                                    throw new Exception();
                                }
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[3] { "Employee Name", "Number Of Repairs Completed", "Number Of Repairs In Progress" };
                                result[0] = header;

                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string[] repair = new string[3] { input, queryResult[i].RepairsCompleted.ToString(), queryResult[i].RepairsInProgress.ToString() };
                                    result[i + 1] = repair;
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No completed or in progress repaird for " + input });
                            }
                            break;
                        case ("DisplayLocation"):
                            //FetchEmployeeLocation
                            try
                            {
                                var queryResult = repo.FetchEmployeeLocation(input);
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[5] { "Employee Name", "Street Address", "City", "Region", "Zip" };
                                result[0] = header;


                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string[] repair = new string[5] { input, queryResult[i].StreetAddress, queryResult[i].City, queryResult[i].Region, queryResult[i].Zip };
                                    result[i + 1] = repair;
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No location for " + input });
                            }
                            break;
                        case ("DisplayHours"):
                            // FetchEmpoyeesByHours
                            try
                            { 
                                var queryResult = repo.FetchEmpoyeesByHours(input);
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[3] { "Employee Name", "Location Address", "Hours" };
                                result[0] = header;


                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string[] repair = new string[3] { input, queryResult[i].StreetAddress, queryResult[i].Hours.ToString()};
                                    result[i + 1] = repair;
                                }
                                
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No hours for " + input });
                            }
                            break;
                        case (""):
                            //FetchEmployee **not complete
                            break;
                    }
                    break;
            }
            return result;
        }

        public string[][] LocationTabQueries(string generalQuery, string specificQuery, string input)
        {
            string[][] result = new string[2][];

            switch (generalQuery)
            {
                case ("DisplayAllLocations"):
                    switch (specificQuery)
                    {
                        case ("DisplaySales"):
                            //FetchSales
                            try
                            {
                                var queryResult = repo.FetchSales(0);
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[2] { "Location Address", "Sales" };
                                result[0] = header;


                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string sales = "$" + queryResult[i].Sales.ToString();
                                    string[] loc = new string[2] { queryResult[i].StreetAddress,  sales};
                                    result[i + 1] = loc;
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No sales to display" });
                            }
                            break;
                        case ("DisplayInventory"):
                            //FetchInventory
                            try
                            {
                                var queryResult = repo.FetchInventory(0);
                                result = new string[queryResult.Count + 1][];

                                string [] header = new string[3]{"Location Address", "Quantity", "Quantity Status"};
                                result[0] = header;


                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string[] loc = new string[3] { queryResult[i].StreetAddress, queryResult[i].Quantity.ToString(), queryResult[i].QuantityStatus };
                                    result[i + 1] = loc;
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No inventory to display" });
                            }
                            break;
                        case ("DisplayUpcomingAppointments"):
                            //**not complete
                            break;
                        case (""):
                            //FetchAllLocationsAddress
                            try
                            {
                                var queryResult = repo.FetchAllLocationsAddress(0);
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[1] { "Location Address" };
                                result[0] = header;


                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string[] loc = new string[1] { queryResult[i].StreetAddress };
                                    result[i + 1] = loc;
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No locations to display" });
                            }
                            break;
                    }
                    break;
                case ("DisplaySpecificLocation"):
                    switch (specificQuery)
                    {
                        case ("DisplaySales"):
                            //FetchSalesSpecific
                            try
                            {
                                var queryResult = repo.FetchSalesSpecific(input);
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[2] { "Location Address", "Sales" };
                                result[0] = header;

                                if (queryResult[1] == null)
                                    throw new Exception();

                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string sales = "$" + queryResult[i].Sales.ToString();
                                    string[] loc = new string[] { input,  sales};
                                    result[i + 1] = loc;
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No sales for " + input });
                            }
                            break;
                        case ("DisplayInventory"):
                            //FetchInventorySpecific
                            try
                            {
                                var queryResult = repo.FetchInventorySpecific(input);
                                result = new string[queryResult.Count + 1][];

                                string[] header = new string[3] { "Location Address", "Quantity", "Quantity Status" };
                                result[0] = header;

                                for (int i = 0; i < queryResult.Count; i++)
                                {
                                    string[] loc = new string[] { input, queryResult[i].Quantity.ToString(), queryResult[i].QuantityStatus };
                                    result[i + 1] = loc;
                                }
                            }
                            catch (Exception)
                            {
                                result[1] = (new string[] { "No sales to display for " + input });
                            }
                            break;
                        case ("DisplayUpcomingAppointments"):
                            //**not complete
                            break;
                        case (""):
                            //Dispaly Specific Location
                            break;
                    }
                    break;
            }
            return result;
        }

        public string[][] RepairTabQueries(string generalQuery, string specificQuery, string input)
        {
            string[][] result = new string[2][];
            switch (generalQuery)
            {
                case ("DisplayPart"):
                    if (specificQuery == "DisplayPrice")
                    {
                        //FetchPartInformaiton --minus quantity
                        try
                        {
                            var queryResult = repo.FetchPartInformation(input);
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[2] { "Part Name", "Price" };
                            result[0] = header;

                            for (int i = 0; i < 1; i++)
                            {
                                string[] loc = new string[] { input, queryResult[i].Price.ToString() };
                                result[i + 1] = loc;
                            }
                        }
                        catch (Exception)
                        {
                            result[1] = (new string[] { "No price for " + input });
                        }
                        break;
                    }
                    else if (specificQuery == "" || specificQuery == "DisplayQuantity")
                    {
                        //FetchPart
                        try
                        {
                            var queryResult = repo.FetchPart(input);
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[3] { "Part Name", "Location", "Quantity" };
                            result[0] = header;

                            for (int i = 0; i < queryResult.Count; i++)
                            {
                                string[] loc = new string[3] { input, queryResult[i].StreetAddress, queryResult[i].Quantity.ToString() };
                                result[i + 1] = loc;
                            }
                        }
                        catch (Exception)
                        {
                            result[1] = (new string[] { "No part with name " + input });
                        }
                        break;
                    }
                    break;
                case ("DisplayRepair"):
                    if (specificQuery == "DisplayPrice")
                    {
                        //get price of repair **not complete
                    }
                    else if (specificQuery == "")
                    {
                        //FetchRepairParts
                        try
                        {
                            var queryResult = repo.FetchRepairParts(input);
                            result = new string[queryResult.Count + 1][];

                            string[] header = new string[3] { "Repair Name", "Part Name", "Price" };
                            result[0] = header;

                            for (int i = 0; i < queryResult.Count; i++)
                            {
                                string[] loc = new string[3] { input, queryResult[i].PartName, queryResult[i].Price.ToString() };
                                result[i + 1] = loc;
                            }
                        }
                        catch (Exception)
                        {
                            result[1] = (new string[] { "No parts for repair " + input });
                        }
                    }
                    break;
            }
            return result;
        }

        public string[][] ReportTabQueries(string generalQuery)
        {
            string[][] result = new string[2][];

            switch (generalQuery)
            {
                case ("DisplayPopularAppointmentTimes"):
                    //FetchPopularApptTimes -- returns StreetAddress, MorningAppointments, AfternoonAppointments, EveningAppointments
                    try
                    {
                        var queryResult = repo.FetchPopularApptTimes(0);
                        result = new string[queryResult.Count + 1][];

                        string[] header = new string[4] { "Location Address", "Morning Appointments", "Afternoon Appointmetns", "Evening Appointments" };
                        result[0] = header;


                        for (int i = 0; i < queryResult.Count; i++)
                        {
                            string[] loc = new string[4] { queryResult[i].StreetAddress, queryResult[i].MorningAppointments.ToString(), queryResult[i].AfternoonAppointments.ToString(), queryResult[i].EveningAppointments.ToString() };
                            result[i + 1] = loc;
                        }
                    }
                    catch (Exception)
                    {
                        result[1] = (new string[] { "No appointments to display" });
                    }
                    break;
                case ("DisplayUpcomingAppointments"):
                    //**not implemented
                    break;
                case ("DisplayPastAppointments"):
                    //**not implemented
                    break;
                case ("DisplayTotalSales"):
                    //FetchSales
                    try
                    {
                        var queryResult = repo.FetchSales(0);
                        result = new string[queryResult.Count + 1][];

                        string[] header = new string[2] { "Location Address", "Sales" };
                        result[0] = header;


                        for (int i = 0; i < queryResult.Count; i++)
                        {
                            string sales = "$" + queryResult[i].Sales.ToString();
                            string[] loc = new string[2] { queryResult[i].StreetAddress, sales };
                            result[i + 1] = loc;
                        }
                    }
                    catch (Exception)
                    {
                        result[1] = (new string[] { "No sales to display" });
                    }
                    break;
                case ("DisplaySalesPerYear"):
                    //FetchSales
                    try
                    {
                        var queryResult = repo.FetchSalesPerYear(0);
                        result = new string[queryResult.Count + 1][];

                        string[] header = new string[3] { "Location Address", "Year", "Sales" };
                        result[0] = header;


                        for (int i = 0; i < queryResult.Count; i++)
                        {
                            string sales = "$" + queryResult[i].Sales.ToString();
                            string[] loc = new string[3] { queryResult[i].StreetAddress, queryResult[i].Year.ToString(), sales };
                            result[i + 1] = loc;
                        }
                    }
                    catch (Exception)
                    {
                        result[1] = (new string[] { "No sales to display" });
                    }
                    break;
            }
            return result;
        }

        public void InsertAppointment(string customerName, string streetAddress, string repairName, DateTime AppointmentTime)
        {
            repo.CreateAppointment(streetAddress, repairName, customerName, AppointmentTime);
        }

        public void InsertRepair(string repairName, string status, string laborCost)
        {
            repo.CreateRepair(repairName, laborCost, status);
        }

        public string[] GetLocation()
         {
            //This is a test
            int val = 0;
            var locationSearch = repo.FetchAllLocationsAddress(val);

            //string empName = "Shannon Colon";
            //RepairHistory;
            //var rhelisttest = repo.FetchRepairHistoryEmployee(empName);
            List<string> returnaddress = new List<string>();
            int count1 = 0;
            foreach (SalesObj X in locationSearch)
            {
                returnaddress.Add(X.StreetAddress);
                count1++;
            }
            string[] retunstring = new string[returnaddress.Count()];
            int count = returnaddress.Count();
            returnaddress.Append("hello");
            foreach(string x in returnaddress)
            {
                count--;
                retunstring[count] = x;

            }

            if (retunstring[0] != null)
            {
                return retunstring;
            }
            else
            {
                string[] ret = new string[1];
                ret[0] = "No locations found";
                return ret;
            }
            

        }

        public void test()
        {
            /*
            repo = new SqlLocationRepository(connectionString);
            transaction = new TransactionScope();
            
            string streetAddress = "testAddress";
            string city = "testcity";
            string region = "testregion";
            string zip = "testzip";

            Location actual = repo.CreateLocation(streetAddress, city, region, zip);
            //repo.CreateLocation(streetAddress, city, region, zip);
            //repo.CreateLocation(streetAddress, city, region, zip);
            //repo.CreateLocation(streetAddress, city, region, zip);
            */
            //System.Windows.Forms.MessageBox.Show(actual.LocationID.ToString());
            //Location help = repo.FetchLocation(6);
            //var thing = repo.RetrieveLocations();

            

            /******not working!!!*****
            string name = "bob";
            string vin = "123";
            Customer customertest = repo.CreateCustomer(name, vin);
            Customer ct1 = repo.CreateCustomer(name, vin);
            Customer ct2 = repo.CreateCustomer(name, vin);
            var custlisttest = repo.RetrieveCustomers();
            */

            


            int testall = 0;
            if(testall == 1)
            {
                ///*****query 1 serch to bring up a part for a specific location not working*****
                //Fetchpartinformation
                //takes streetAddress and part name              
                string partName = "ipsum porta";
                var thinglist = repo.FetchPartInformation(partName);
                //returns Quantity, price, 
                //*/

                ///*****query 2 search to bring up repair history works*****
                string custname = "Vincent Flores";
                var help = repo.FetchRepairHistoryCustomer(custname);
                //*/

                ///*****query 3 FetchRepairHistoryCustomer working*****
                string vin2 = "28522458199";
                var reptest = repo.FetchRepairHistoryVehicle(vin2);
                //*/

                ///*****query 4 FetchRepairHistoryEmployee working*****
                string empName = "Shannon Colon";
                var rhelisttest = repo.FetchRepairHistoryEmployee(empName);
                //*/

                ///*****query 5 FetchPart working*****
                string PartName = "vitae,  orci.";
                var fplist = repo.FetchPart(PartName);
                //*/

                ///*****query 6 FetchRepairParts working*****
                string repairName = "fringilla euismod";
                var frplist = repo.FetchRepairParts(repairName);
                //*/

                ///*****query 7 FetchEmployeeLocation working*****
                string felempname = "Norman Abbott";
                var fellist = repo.FetchEmployeeLocation(felempname);
                //*/

                ///*****query 8 FetchEmployeeRepairCounts working*****
                string fertest = "Colleen Mcleod";
                var ferlisttest = repo.FetchEmployeeRepairCounts(fertest);
                //*/

                ///*****query 9 FetchAllEmployeeRepairCounts working*****
                int x = 0;//takes in a 0 to keep it simple
                var faerclisttest = repo.FetchAllEmployeeRepairCounts(x);
                //*/

                ///*****query 10 FetchSalesSpecific working*****
                string fssstreetAddress = "P.O. Box 776, 7543 Convallis Rd.";
                var fsslist = repo.FetchSalesSpecific(fssstreetAddress);
                //*/

                // /*****query 11 FetchSales working*****
                int blank = 0;
                var fslist = repo.FetchSales(blank);
                //*/

                ///*****query 12 FetchInventorySpecific working*****
                string streetAddress1 = "2483 Nulla St.";
                var sAlist = repo.FetchInventorySpecific(streetAddress1);
                //*/

                ///*****query 13 FetchInventory working*****
                int blank1 = 0;
                var filist = repo.FetchInventory(blank1);
                //*/

                ///*****query 14 FetchReparsinProgress working*****
                string fripaddress = "P.O. Box 776, 7543 Convallis Rd.";
                var friplist = repo.FetchReparsinProgress(fripaddress);
                //*/


                ///*****query 16 FetchAllLocationsAddress working*****
                int blank2 = 0;
                var falalist = repo.FetchAllLocationsAddress(blank2);
                //*/

                ///*****query 17 FetchAllEmployees missing sql*****
                int blank3 = 0;
                var faelist = repo.FetchAllEmployees(blank3);
                //*/

                ///*****query 19 FetchRepeatRepairsSpecific returns nothing*****
                string custName = "Zeus Terry";
                var frrslist = repo.FetchRepeatRepairsSpecific(custName);
                //*/

                ///*****query 19 FetchRepeatRepairs returns nothing*****
                int blank4 = 0;
                var frrlist = repo.FetchRepeatRepairs(blank4);
                //*/

                ///*****query 22 FetchPopularApptTimes working*****
                int blank5 = 0;
                var fpatlist = repo.FetchPopularApptTimes(blank5);
                //*/

                ///*****query 23 FetchSalesPerYear untested*****
                int blank6 = 0;
                var fspylist = repo.FetchSalesPerYear(blank6);
                //*/

                ///*****query 24 FetchCustomerReport untested*****
                string fcrempName = "Zeus Terry";
                var fcrlist = repo.FetchCustomerReport(fcrempName);
                //*/

                ///*****query 25 FetchVinReport untested*****
                string fvrvin = "06434275099";
                var fvrlist = repo.FetchVinReport(fvrvin);
                //*/

                ///*****query 26 FetchEmpoyeesByHours untested*****
                string febhempName = "Travis French";
                var frbhlist = repo.FetchEmployeesByHours(febhempName);
                //*/


                ///******q 28 working*****
                //'427-9420 Mauris. Ave', 'fringilla euismod', 'Randall Park', '2020-06-21 11:13:00'
                //StreetAddress, RepairName, CustomerName, AppointmentTime
                DateTime dateTime = new DateTime(2020, 06, 21, 11, 13, 00);
                string streetAddress = "427-9420 Mauris. Ave";
                string repName = "fringilla euismod";
                string cacustName = "Randall Park";
                Appointment x1 = repo.CreateAppointment(streetAddress, repName, cacustName, dateTime);
                var aptlisttest = repo.RetreiveAppointments();
                //*/

                ///*****q29 CreateRepair working*****
                string crrepName = "window replacement";
                string crlaborCost = "$1.25";
                string crstatus = "Complete";
                Repair crtest = repo.CreateRepair(crrepName, crlaborCost, crstatus);
                //*/
            }

        }

        //public void 

    }
}
