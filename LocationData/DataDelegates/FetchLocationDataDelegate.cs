using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace LocationData.DataDelegates
{
    internal class FetchLocationDataDelegate : DataReaderDelegate<Location>
    {
        private readonly int LocationID;

        public FetchLocationDataDelegate(int locationID)
            : base("AutoShop.FetchLocation")
        {
            this.LocationID = locationID;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("LocationID", SqlDbType.Int);
            p.Value = LocationID;
        }

        public override Location Translate(SqlCommand command, IDataRowReader reader)
        {
            if(!reader.Read())
            {
                throw new RecordNotFoundException(LocationID.ToString());
            }

            return new Location(
                LocationID,
                reader.GetString("StreetAddress"),
                reader.GetString("City"),
                reader.GetString("Region"),
                reader.GetString("Zip"));

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
