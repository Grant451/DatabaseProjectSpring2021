using DataAccess;
using LocationData.Models;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchRepairHistoryDataDelegate : DataReaderDelegate<IReadOnlyList<RepairHistory>>
    {
        private readonly string CustomerName;

        public FetchRepairHistoryDataDelegate(string custname)
            : base("AutoShop.FetchRepairHistoryCustomer")
        {
            this.CustomerName = custname;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CustomerName", SqlDbType.NVarChar);
            p.Value = CustomerName;
        }

        public override IReadOnlyList<RepairHistory> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<RepairHistory>();
            while (reader.Read())
            {
                temp.Add(new RepairHistory(
                    CustomerName,
                    reader.GetString("RepairName")
                          )
                    );
            }
            return temp;
        }
    }
}