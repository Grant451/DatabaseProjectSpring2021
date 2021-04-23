using System;
using System.Data.SqlClient;
using System.Transactions;
using DataAccess;

namespace DatabaseProjectSpring2021
{
    public class SqlCommandExecutor
    {
        private readonly string connectionString;

        public SqlCommandExecutor(string server, string database) : this($"Server={server};Integrated Security=SSPI;")
        { }

        public SqlCommandExecutor(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("The parameter connot be null or empty.", nameof(connectionString));
            }
            this.connectionString = connectionString;
        }

        public void ExecuteNonQuery(IDataDelegate dataDelegate)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(dataDelegate.ProcedureName, connection))
                    {
                        dataDelegate.PrepareCommand(command);
                        connection.Open();
                        command.ExecuteNonQuery();
                        transaction.Complete();
                    }
                }
            }
        }

        public T ExecuteNonQuery<T>(INonQueryDataDelegate<T> dataDelegate)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand(dataDelegate.ProcedureName, connection))
                    {
                        dataDelegate.PrepareCommand(command);
                        connection.Open();
                        command.ExecuteNonQuery();
                        transaction.Complete();
                        return dataDelegate.Translate(command);
                    }
                }
            }
        }
        
        public T ExecuteReader<T>(IDataReaderDelegate<T> dataDelegate)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(dataDelegate.ProcedureName, connection))
                {
                    dataDelegate.PrepareCommand(command);
                    connection.Open();
                    var reader = command.ExecuteReader();
                    return dataDelegate.Translate(command, new DataRowReader(reader));
                }
            }
        }


    }
}
