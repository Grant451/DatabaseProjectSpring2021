using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using LocationData.Models;

namespace LocationData
{
    internal class RetrieveCustomersDataDelegate : IDataReaderDelegate<IReadOnlyList<Customer>>
    {
        public string ProcedureName => throw new System.NotImplementedException();

        public void PrepareCommand(SqlCommand command)
        {
            throw new System.NotImplementedException();
        }

        public IReadOnlyList<Customer> Translate(SqlCommand command, IDataRowReader reader)
        {
            throw new System.NotImplementedException();
        }
    }
}