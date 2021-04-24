using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using LocationData.Models;
using System.Data;

namespace LocationData
{
    internal class FetchPartDataDelegate : DataReaderDelegate<IReadOnlyList<LocationQuantity>>
    {
        private string PartName;

        public FetchPartDataDelegate(string partName)
            : base("AutoShop.FetchPart")
        {
            this.PartName = partName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("PartName", SqlDbType.NVarChar);
            p.Value = PartName;
        }

        public override IReadOnlyList<LocationQuantity> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<LocationQuantity>();
            while (reader.Read())
            {
                temp.Add(new LocationQuantity(
                            reader.GetInt32("LocationID"),
                            reader.GetString("StreetAddress"),
                            reader.GetInt32("Quantity")
                            )
                        );
            }
            return temp;
        }
    }
}