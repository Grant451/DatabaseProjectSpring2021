using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class ColumnNotFoundException : Exception
    {
        public ColumnNotFoundException(string name, Exception innerException = null) 
            : base($"The column [{name}] was not found in the result set.", innerException)
        {

        }
    }
}
