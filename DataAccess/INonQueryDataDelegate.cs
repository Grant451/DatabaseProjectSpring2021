using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    public interface INonQueryDataDelegate<out T> : IDataDelegate
    {
        T Translate(SqlCommand command);
    }
}
