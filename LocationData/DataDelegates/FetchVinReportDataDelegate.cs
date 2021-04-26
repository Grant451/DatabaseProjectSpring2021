using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchVinReportDataDelegate : DataReaderDelegate<IReadOnlyList<RepairHistory>>
    {
        private string fvrvin;

        public FetchVinReportDataDelegate(string fvrvin)
            : base("AutoShop.FetchVinReport")
        {
            this.fvrvin = fvrvin;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("VinNumber", SqlDbType.NVarChar);
            p.Value = fvrvin;
        }

        public override IReadOnlyList<RepairHistory> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<RepairHistory>();
            while (reader.Read())
            {
                temp.Add(new RepairHistory(
                    reader.GetInt32("CustomerID"),
                    reader.GetString("CustomerName"),
                    reader.GetInt32("RepairID"),
                    reader.GetString("vinnumber")
                          )
                    );
            }
            return temp;
        }
    }
}