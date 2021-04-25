using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class EmployeeLocation
    {
        public string StreetAddress { get; }

        public string City { get; }

        public string Region { get; }

        public string Zip { get; }

        public EmployeeLocation(string streetAddress, string city, string region, string zip)
        {
            StreetAddress = streetAddress;
            City = city;
            Region = region;
            Zip = zip;
        }
    }
}
