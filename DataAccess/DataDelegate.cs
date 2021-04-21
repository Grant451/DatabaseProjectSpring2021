using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    class DataDelegate
    {
        public abstract class DataDelegate : IDataDelegate
        {
            public string ProcedureName { get; }

            protected DataDelegate(string procedureName)
            {
                if (string.IsNullOrWhiteSpace(procedureName)) 
                {
                    throw new ArgumentException("The procedure name cannot be null or empty.", nameof(procedureName));
                }
                ProcedureName = procedureName;
            }

            public virtual void PrepareCommand(SqlCommand command)
            {
                command.CommandType = CommandType.StoredProcedure;
            }
        }
    }
}
