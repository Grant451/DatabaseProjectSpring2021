using System.Collections.Generic;
using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace LocationData
{
    internal class FetchRepeatRepairsDataDelegate : DataReaderDelegate<IReadOnlyList<RepairHistory>>
    {
        private int blank;

        public FetchRepeatRepairsDataDelegate(int blank)
            : base("AutoShop.FetchRepeatRepairs")
        {
            this.blank = blank;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<RepairHistory> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<RepairHistory>();
            while (reader.Read())
            {
                temp.Add(new RepairHistory(
                    reader.GetString("EmployeeName"),
                    reader.GetString("CustomerName"),
                    reader.GetString("RepairName"),
                    reader.GetInt32("TimesRepaired")
                          )
                    );
            }
            return temp;
        }
    }
}