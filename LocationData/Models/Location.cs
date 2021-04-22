using System;
using System.Collections.Generic;
using System.Text;

namespace LocationData.Models
{
    public class Location
    {
        public int LocationID { get; }

        public string StreetAddress { get; }

        public string City { get; }

        public string Region { get; }

        public string Zip { get; }

        public Location(int locationID, string streetAddress, string city, string region, string zip)
        {
            LocationID = locationID;
            StreetAddress = streetAddress;
            City = city;
            Region = region;
            Zip = zip;
        }
    }
}
