using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchReparsinProgressDataDelegate : DataReaderDelegate<IReadOnlyList<RepairHistory>>
    {
        private string streetAddress;

        public FetchReparsinProgressDataDelegate(string streetAddress)
            : base("AutoShop.FetchReparsinProgress")
        {
            this.streetAddress = streetAddress;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("StreetAddress", SqlDbType.NVarChar);
            p.Value = streetAddress;
        }

        public override IReadOnlyList<RepairHistory> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<RepairHistory>();
            while (reader.Read())
            {
                temp.Add(new RepairHistory(
                    reader.GetString("RepairName"),
                    reader.GetString("EmployeeName"),
                    reader.GetString("CustomerName")
                          )
                    );
            }
            return temp;
        }
    }
}