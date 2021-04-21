using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using LocationData.Models;

namespace LocationData
{
    class SqlLocationRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlLocationRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }
    }
}
