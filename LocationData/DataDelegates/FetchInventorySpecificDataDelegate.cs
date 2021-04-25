using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchInventorySpecificDataDelegate : DataReaderDelegate<IReadOnlyList<PartSearch>>
    {
        private string streetAddress;

        public FetchInventorySpecificDataDelegate(string streetAddress)
            : base("AutoShop.FetchInventorySpecific")
        {
            this.streetAddress = streetAddress;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("StreetName", SqlDbType.NVarChar);
            p.Value = streetAddress;
        }

        public override IReadOnlyList<PartSearch> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<PartSearch>();
            while (reader.Read())
            {
                temp.Add(new PartSearch(
                    reader.GetString("PartName"),
                    reader.GetInt32("Quantity"),
                    reader.GetString("QuantityStatus")
                          )
                    );
            }
            return temp;
        }
    }
}