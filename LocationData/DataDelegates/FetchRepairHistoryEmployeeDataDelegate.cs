using DataAccess;
using LocationData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace LocationData
{
    internal class FetchRepairHistoryEmployeeDataDelegate : DataReaderDelegate<IReadOnlyList<RepairHistory>>
    {
        private string empName;

        public FetchRepairHistoryEmployeeDataDelegate(string empName)
            : base("AutoShop.FetchRepairHistoryEmployee")
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
         *    @EmployeeName NVARCHAR(255)
        AS

        SELECT E.EmployeeName, R.RepairName
        */

        public override IReadOnlyList<RepairHistory> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<RepairHistory>();

            while(reader.Read())
            {
                temp.Add(
                    new RepairHistory(
                        reader.GetString("EmployeeName"),
                        reader.GetString("RepairName")
                        )
                    );
            }
            return temp;
        }
    }
}
 