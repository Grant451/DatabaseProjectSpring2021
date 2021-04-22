using System;
using System.Collections.Generic;
using System.Text;
using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace LocationData.DataDelegates
{
    internal class CreateLocationDataDelegate : NonQueryDataDelegate<Location>
    {
        public readonly string streetAddress;
        public readonly string city;
        public readonly string region;
        public readonly string zip;

        public CreateLocationDataDelegate(string streetAddress, string city, string region, string zip)
            : base("Location.CreateLocation")
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.region = region;
            this.zip = zip;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("StreetAddress", SqlDbType.NVarChar);
            p.Value = streetAddress;
            p = command.Parameters.Add("City", SqlDbType.NVarChar);
            p.Value = city;
            p = command.Parameters.Add("Region", SqlDbType.NVarChar);
            p.Value = region;
            p = command.Parameters.Add("Zip", SqlDbType.NVarChar);
            p.Value = zip;
            p = command.Parameters.Add("LocationID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override Location Translate(SqlCommand command)
        {
            return new Location((int)command.Parameters["LocationID"].Value, streetAddress, city, region, zip);
        }
    }
}
