using DataAccess;
using LocationData.Models;
using System.Data;
using System.Data.SqlClient;

namespace LocationData
{
    internal class FetchRepairHistoryDataDelegate : DataReaderDelegate<RepairHistory>
    {
        private readonly string CustomerName;

        public FetchRepairHistoryDataDelegate(string custname)
            : base("Location.FetchRepairHistoryCustomer")
        {
            this.CustomerName = custname;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CustomerName", SqlDbType.NVarChar);
            p.Value = CustomerName;
        }

        public override RepairHistory Translate(SqlCommand command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(CustomerName.ToString());

            return new RepairHistory(
                    CustomerName,
                    reader.GetString("RepairName")
                    );
        }
    }
}