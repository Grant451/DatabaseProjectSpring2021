using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class LocationQuantity
    {
        public int LocationID { get; }

        public string StreetAddress { get; }

        public int Quantity { get; }

        public LocationQuantity(int locationID, string streetAddress, int quantity)
        {
            LocationID = locationID;
            StreetAddress = streetAddress;
            Quantity = quantity;
        }
    }
}
