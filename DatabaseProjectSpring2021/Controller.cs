﻿using System;
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
        public List<string> CustomerTabQueries(string generalQuery, string specificQuery)
        {
            List<string> result = new List<string>();
            switch (generalQuery)
            {
                case ("DisplayAllCustomers"):
                    if (specificQuery == "DisplayRepeatedRepairs")
                    {
                        //FetchRepeatedRepairs
                        var queryresult = repo.FetchRepeatRepairs(1);
                        return null;
                    }
                    else if (specificQuery == "")
                    {
                        //RetrieveCustomers -- fetch all customers
                        var queryresult = repo.RetrieveCustomers();
                        foreach (c in queryresult)
                    }

                    break;
                case ("DisplaySpecificCustomer"):
                    if (specificQuery == "DisplayRepeatedRepairs")
                    {
                        //FetchRepeatedRepairsSpecific
                    }
                    else if (specificQuery == "DisplayPastRepairs")
                    {
                        //FetchRepairHistoryCustomer
                    }
                    else if (specificQuery == "DisplayUpcomingAppointments")
                    {
                        //FetchUpcomingAppointmentsCustomer **not complete
                    }
                    else if (specificQuery == "")
                    {
                        //RetrieveSpecificCustomer -- Fetch specific customer
                        
                    }
                    break;
            }
            return result;
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

            /******working*****
            DateTime dateTime = new DateTime(2015, 12, 31, 5, 10, 20);
            int loc = 0;
            int rep = 0;
            int cust = 0;
            Appointment x1 = repo.CreateAppointment(loc, rep, cust, dateTime);
            Appointment x2 = repo.CreateAppointment(loc, rep, cust, dateTime);
            Appointment x3 = repo.CreateAppointment(loc, rep, cust, dateTime);
            var aptlisttest = repo.RetreiveAppointments();
            */

            /******not working!!!*****
            string name = "bob";
            string vin = "123";
            Customer customertest = repo.CreateCustomer(name, vin);
            Customer ct1 = repo.CreateCustomer(name, vin);
            Customer ct2 = repo.CreateCustomer(name, vin);
            var custlisttest = repo.RetrieveCustomers();
            */

            /*****query 1 serch to bring up a part for a specific location not working*****
            //Fetchpartinformation
            //takes streetAddress and part name
            string streetAddress = "3521 Quam. Avenue";                
            string partName = "ipsum porta";
            PartSearch thing = repo.FetchPartInformation(streetAddress, partName);
            //returns Quantity, price, 
            */

            
            /*****query 2 search to bring up repair history works*****
            string custname = "Vincent Flores";
            RepairHistory help = repo.FetchRepairHistoryCustomer(custname);
            */

            /*****query 3 FetchRepairHistoryCustomer working*****
            string vin2 = "28522458199";
            RepairHistory  reptest = repo.FetchRepairHistoryVehicle(vin2);
            */

            /*****query 4 FetchRepairHistoryEmployee working*****
            string empName = "Shannon Colon";
            var rhelisttest = repo.FetchRepairHistoryEmployee(empName);
            */

            /*****query 5 FetchPart working*****
            string PartName = "vitae,  orci.";
            var fplist = repo.FetchPart(PartName);
            */

            /*****query 6 FetchRepairParts working*****
            string repairName = "fringilla euismod";
            var frplist = repo.FetchRepairParts(repairName);
            */

            /*****query 7 FetchEmployeeLocation working*****
            string felempname = "Norman Abbott";
            var fellist = repo.FetchEmployeeLocation(felempname);
            */

            /*****query 8 FetchEmployeeRepairCounts working*****
            string fertest = "Colleen Mcleod";
            var ferlisttest = repo.FetchEmployeeRepairCounts(fertest);
            */

            /*****query 9 FetchAllEmployeeRepairCounts working*****
            int x = 0;//takes in a 0 to keep it simple
            var faerclisttest = repo.FetchAllEmployeeRepairCounts(x);
            */

            /*****query 10 FetchSalesSpecific working*****
            string fssstreetAddress = "P.O. Box 776, 7543 Convallis Rd.";
            var fsslist = repo.FetchSalesSpecific(fssstreetAddress);
            */

            /*****query 11 FetchSales working*****
            int blank = 0;
            var fslist = repo.FetchSales(blank);
            */

            /*****query 12 FetchInventorySpecific working*****
            string streetAddress1 = "2483 Nulla St.";
            var sAlist = repo.FetchInventorySpecific(streetAddress1);
            */

            /*****query 13 FetchInventory working*****
            int blank1 = 0;
            var filist = repo.FetchInventory(blank1);
            */

            /*****query 14 FetchReparsinProgress working*****
            string fripaddress = "P.O. Box 776, 7543 Convallis Rd.";
            var friplist = repo.FetchReparsinProgress(fripaddress);
            */
            

            /*****query 16 FetchAllLocationsAddress working*****
            int blank2 = 0;
            var falalist = repo.FetchAllLocationsAddress(blank2);
            */

            /*****query 17 FetchAllEmployees missing sql*****
            int blank3 = 0;
            var faelist = repo.FetchAllEmployees(blank3);
            */

            /*****query 19 FetchRepeatRepairsSpecific returns nothing*****
            string custName = "Zeus Terry";
            var frrslist = repo.FetchRepeatRepairsSpecific(custName);
            */

            /*****query 19 FetchRepeatRepairs returns nothing*****
            int blank4 = 0;
            var frrlist = repo.FetchRepeatRepairs(blank4);
            */

            /*****query 22 FetchPopularApptTimes working*****
            int blank5 = 0;
            var fpatlist = repo.FetchPopularApptTimes(blank5);
            */

        }

        //public void 

    }
}
