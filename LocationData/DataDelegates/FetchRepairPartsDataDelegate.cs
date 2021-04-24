using System.Collections.Generic;
using DataAccess;
using LocationData.Models;
using System.Data;
using System.Data.SqlClient;

namespace LocationData
{
    internal class FetchRepairPartsDataDelegate : DataReaderDelegate<IReadOnlyList<PartSearch>>
    {
        private readonly string RepairName;

        public FetchRepairPartsDataDelegate(string repairName)
            : base("AutoShop.FetchRepairParts")
        {
            RepairName = repairName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("RepairName", SqlDbType.NVarChar);
            p.Value = RepairName;
        }

        public override IReadOnlyList<PartSearch> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<PartSearch>();
            while (reader.Read())
            {
                temp.Add(new PartSearch(
                    reader.GetString("PartName"),
                    reader.GetString("Price")
                          )
                    );
            }
            return temp;
        }
    }
}