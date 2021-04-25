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
        public string[] GetLocation()
         {
            //This is a test
            

            string empName = "Shannon Colon";
            var rhelisttest = repo.FetchRepairHistoryEmployee(empName);
            List<string> returnaddress = new List<string>();
            int count1 = 0;
            foreach (RepairHistory X in rhelisttest){
                returnaddress.Add(X.CustomerName);
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

            /******working*****
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
            string vin = "28522458199";
            RepairHistory  reptest = repo.FetchRepairHistoryVehicle(vin);
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

            /*****query 12 FetchInventorySpecific untested*****
            string streetAddress = "2483 Nulla St.";
            var sAlist = repo.FetchInventorySpecific(streetAddress);
            */

            /*****query 13 FetchInventory untested*****
            int blank = 0;
            var filist = repo.FetchInventory(blank);
            */

            /*****query 16 FetchAllLocationsAddress working*****
            int blank = 0;
            var falalist = repo.FetchAllLocationsAddress(blank);
            */



        }

    }
}
