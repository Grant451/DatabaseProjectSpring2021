using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using LocationData.Models;
using System.Data;

namespace LocationData
{
    internal class FetchEmployeeRepairCountsDataDelegate : DataReaderDelegate<IReadOnlyList<EmployeeRepair>>
    {
        private string empName;

        public FetchEmployeeRepairCountsDataDelegate(string empName)
            : base("AutoShop.FetchEmployeeRepairCounts")
        {
            this.empName = empName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("EmployeeName", SqlDbType.NVarChar);
            p.Value = empName;
        }

        /*
           @EmployeeName NVARCHAR(255)
            AS
            SELECT COUNT(DISTINCT IIF(R.[Status] = 'Complete', R.[Status], NULL)) AS RepairsCompleted,
	        COUNT(DISTINCT IIF(R.[Status] = 'In Progress', R.[Status], NULL)) AS RepairsInProgress
        */

        public override IReadOnlyList<EmployeeRepair> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<EmployeeRepair>();
            while(reader.Read())
            {
                temp.Add(
                    new EmployeeRepair(
                        reader.GetInt32("RepairsCompleted"),
                        reader.GetInt32("RepairsInProgress")
                        )
                    );
            }
            return temp;
        }

    }
}