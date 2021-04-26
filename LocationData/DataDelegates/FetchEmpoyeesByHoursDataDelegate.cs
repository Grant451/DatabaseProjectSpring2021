using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchEmpoyeesByHoursDataDelegate : DataReaderDelegate<IReadOnlyList<HourReport>>
    {
        private string febhempName;

        public FetchEmpoyeesByHoursDataDelegate(string febhempName)
            : base("AutoShop.FetchEmployeesByHours")
        {
            this.febhempName = febhempName;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("EmployeeName", SqlDbType.NVarChar);
            p.Value = febhempName;
        }

        public override IReadOnlyList<HourReport> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<HourReport>();
            while (reader.Read())
            {
                temp.Add(new HourReport(
                    reader.GetString("EmployeeName"),
                    reader.GetDateTime("Hours"),
                    reader.GetString("StreetAddress")
                          )
                    );
            }
            return temp;
        }
    }
}