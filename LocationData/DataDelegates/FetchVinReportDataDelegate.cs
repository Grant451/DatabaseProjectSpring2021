using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchVinReportDataDelegate : DataReaderDelegate<IReadOnlyList<RepairHistory>>
    {
        private string fvrvin;

        public FetchVinReportDataDelegate(string fvrvin)
            : base("")
        {
            this.fvrvin = fvrvin;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("VinNumber", SqlDbType.Int);
            p.Value = fvrvin;
        }

        public override IReadOnlyList<RepairHistory> Translate(SqlCommand command, IDataRowReader reader)
        {
            throw new System.NotImplementedException();
        }
    }
}