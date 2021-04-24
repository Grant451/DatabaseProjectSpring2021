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
    internal class GetLocationDataDelegate : DataReaderDelegate<Location>
    {
        private readonly string region;

        public GetLocationDataDelegate(string region)
            : base("AutoShop.GetLocation")
        {
            this.region = region;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("Region",region);
        }

        public override Location Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                return null;
            return new Location(
                reader.GetInt32("LocationID"),
                reader.GetString("StreetAddress"),
                reader.GetString("City"),
                region,
                reader.GetString("Zip")
                );
            /*
            LocationID = locationID;
            StreetAddress = streetAddress;
            City = city;
            Region = region;
            Zip = zip;
            */
        }
    }
}
