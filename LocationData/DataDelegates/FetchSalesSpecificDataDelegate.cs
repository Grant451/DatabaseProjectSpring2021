using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchSalesSpecificDataDelegate : DataReaderDelegate<IReadOnlyList<SalesObj>>
    {
        private readonly string streetAddress;

        public FetchSalesSpecificDataDelegate(string streetAddress)
            : base("AutoShop.FetchSalesSpecific")
        {
            this.streetAddress = streetAddress;
        }


        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("StreetAddress", SqlDbType.NVarChar);
            p.Value = streetAddress;
        }

        public override IReadOnlyList<SalesObj> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<SalesObj>();
            while (reader.Read())
            {
                temp.Add(new SalesObj(
                                    reader.GetDouble("Sales")
                                    )
                    );
            }
            return temp;
        }
    }
}