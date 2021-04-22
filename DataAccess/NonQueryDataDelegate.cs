using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class NonQueryDataDelegate<T> : DataDelegate, INonQueryDataDelegate<T>
    {
        protected NonQueryDataDelegate(string procedureName)
            : base(procedureName)
        {

        }

        public abstract T Translate(SqlCommand command);
    }
}
