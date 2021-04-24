using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using LocationData.Models;
using System.Data;

namespace LocationData
{
    internal class FetchAllEmployeeRepairCountsDataDelegate : DataReaderDelegate<IReadOnlyList<EmployeeRepair>>
    {

        public FetchAllEmployeeRepairCountsDataDelegate(int blank)
            : base ("AutoShop.FetchAllEmployeeRepairCounts")
        {
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<EmployeeRepair> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<EmployeeRepair>();
            while (reader.Read())
            {
                temp.Add(new EmployeeRepair (
                            reader.GetString("EmployeeName"),
                            reader.GetInt32("RepairsCompleted"),
                            reader.GetInt32("RepairsInProgress")
                            )
                        );
            }
            return temp;
        }
    }
}