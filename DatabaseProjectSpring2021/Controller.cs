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


        public void test()
        {
            repo = new SqlLocationRepository(connectionString);
            transaction = new TransactionScope();

            string streetAddress = "testAddress";
            string city = "testcity";
            string region = "testregion";
            string zip = "testzip";

            Location actual = repo.CreateLocation(streetAddress, city, region, zip);
            /*
            reader.GetInt32("LocationID"),
            reader.GetString("StreetAddress"),
            reader.GetString("City"),
            region,
            reader.GetString("Zip")
            */
        }
        
    }
}
