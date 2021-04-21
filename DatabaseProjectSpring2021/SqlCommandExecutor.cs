using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjectSpring2021
{
    class SqlCommandExecutor
    {
        private readonly string connectionString;

        public SqlCommandExecutor(string server, string database) : this ($"Server={server};Integrated Security=SSPI;")
        { }

        public SqlCommandExecutor(string connectionString)
        {
            if(string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("The parameter connot be null or empty.", nameof(connectionString));
            }
            this.connectionString = connectionString;
        }

    }
}
