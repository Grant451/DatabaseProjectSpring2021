using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IDataRowReader
    {
        bool Read();

        byte GetByte(string name);

        double GetDouble(string name);

        DateTime GetDateTime(string name);

        int GetInt32(string name);

        string GetString(string name);

        T GetValue<T>(string name);
    }
}
