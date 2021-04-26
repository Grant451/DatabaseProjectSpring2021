using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using LocationData.Models;
using System.Data;

namespace LocationData
{
    internal class FetchInventoryDataDelegate : DataReaderDelegate<IReadOnlyList<PartSearch>>
    {
        private int blank;

        public FetchInventoryDataDelegate(int blank)
            : base("AutoShop.FetchInventory")
        {
            this.blank = blank;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<PartSearch> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<PartSearch>();
            while (reader.Read())
            {
                temp.Add(new PartSearch(
                    reader.GetString("StreetAddress"),
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