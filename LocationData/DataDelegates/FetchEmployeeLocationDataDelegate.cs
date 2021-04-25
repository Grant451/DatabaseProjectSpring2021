using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using LocationData.Models;
using System.Data;

namespace LocationData
{
    internal class FetchEmployeeLocationDataDelegate : DataReaderDelegate<IReadOnlyList<EmployeeLocation>>
    {
        private object felemname;

        public FetchEmployeeLocationDataDelegate(object felemname)
            : base("AutoShop.FetchEmployeeLocation")
        {
            this.felemname = felemname;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("EmployeeName", SqlDbType.NVarChar);
            p.Value = felemname;
        }

        public override IReadOnlyList<EmployeeLocation> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<EmployeeLocation>();

            while (reader.Read())
            {
                temp.Add(new EmployeeLocation(
                            //reader.GetInt32("LocationID"),
                            reader.GetString("StreetAddress"),
                            reader.GetString("City"),
                            reader.GetString("Region"),
                            reader.GetString("Zip")
                            )
                   );
            }

            return temp;
        }
    }
}