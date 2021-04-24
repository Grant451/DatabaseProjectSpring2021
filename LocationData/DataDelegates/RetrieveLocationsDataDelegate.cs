using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using LocationData.Models;
using System.Data.SqlClient;

namespace LocationData.DataDelegates
{
    internal class RetrieveLocationsDataDelegate : DataReaderDelegate<IReadOnlyList<Location>>
    {
        public RetrieveLocationsDataDelegate()
            : base("AutoShop.RetrieveLocations")
        {
        }

        public override IReadOnlyList<Location> Translate(SqlCommand command, IDataRowReader reader)
        {
            var locations = new List<Location>();
            while(reader.Read())
            {
                locations.Add(
                    new Location(
                        reader.GetInt32("LocationID"),
                        reader.GetString("StreetAddress"),
                        reader.GetString("City"),
                        reader.GetString("Region"),
                        reader.GetString("Zip")
                        )
                    );
            /*
            LocationID = locationID;
            StreetAddress = streetAddress;
            City = city;
            Region = region;
            Zip = zip;
            */
            }
            return locations;
        }
    }
}
