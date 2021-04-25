using System.Collections.Generic;
using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace LocationData
{
    internal class FetchRepeatRepairsSpecificDataDelegate : DataReaderDelegate<IReadOnlyList<RepairHistory>>
    {
        private string custName;

        public FetchRepeatRepairsSpecificDataDelegate(string custName)
            : base("AutoShop.FetchRepeatRepairsSpecific")
        {
            this.custName = custName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CustomerName", SqlDbType.NVarChar);
            p.Value = custName;
        }

        public override IReadOnlyList<RepairHistory> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<RepairHistory>();
            while (reader.Read())
            {
                temp.Add(new RepairHistory(
                    //reader.GetString("EmployeeName"),
                    reader.GetString("RepairName"),
                    reader.GetInt32("RepeatRepairs")
                          )
                    );
            }
            return temp;
        }
    }
}