using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using LocationData.Models;
using System.Data;
using System.Data.SqlClient;


namespace LocationData.DataDelegates
{
    internal class FetchRepairHistoryVehicleDataDelegate : DataReaderDelegate<IReadOnlyList<RepairHistory>>
    {
        /*
        @vinnumber NVARCHAR(11)
        AS
        SELECT C.CustomerName, R.RepairName
        */

        private readonly string VinNumber;

        public FetchRepairHistoryVehicleDataDelegate(string vinNumber)
            : base("AutoShop.FetchRepairHistoryVehicle")
        {
            this.VinNumber = vinNumber;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("vinnumber", SqlDbType.NVarChar);
            p.Value = VinNumber;
        }

        public override IReadOnlyList<RepairHistory> Translate(SqlCommand command, IDataRowReader reader)
        {

            var temp = new List<RepairHistory>();
            while (reader.Read())
            {
                temp.Add(new RepairHistory(
                    VinNumber,
                    reader.GetString("CustomerName"),
                    reader.GetString("RepairName")
                          )
                    );
            }
            return temp;

        }
    }
}
