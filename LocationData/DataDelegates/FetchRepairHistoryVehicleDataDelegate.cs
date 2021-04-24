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
    internal class FetchRepairHistoryVehicleDataDelegate : DataReaderDelegate<RepairHistory>
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

        public override RepairHistory Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(VinNumber);

            return new RepairHistory(
                VinNumber,//might take the vin, but the constructor for RepairHistory doesn't allow for a vin
                reader.GetString("CustomerName"),
                reader.GetString("RepairName")
                );
        }
    }
}
