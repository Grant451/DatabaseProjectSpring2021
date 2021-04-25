using System.Collections.Generic;
using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace LocationData
{
    internal class FetchAllEmployeesDataDelegate : DataReaderDelegate<IReadOnlyList<EmployeeRepair>>
    {
        private int blank;

        public FetchAllEmployeesDataDelegate(int blank)
            : base("AutoShop.FetchAllEmployees")
        {
            this.blank = blank;
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
                temp.Add(new EmployeeRepair(
                    reader.GetString("EmployeeName")
                          )
                    );
            }
            return temp;
        }
    }
}