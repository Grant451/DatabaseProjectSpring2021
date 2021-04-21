using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DataAccess
{
    internal class  DataRowReader : IDataRowReader
    {
        private readonly SqlDataReader reader;

        public DataRowReader(SqlDataReader reader)
        {
            this.reader = reader;
        }

        public byte GetByte(string name)
        {
            return GetValue(name, reader.GetByte);
        }

        public DateTimeOffset GetDateTimeOffset(string name)
        {
            return GetValue(name, reader.GetDateTimeOffset);
        }

        public int GetInt32(string name)
        {
            return GetValue(name, reader.GetInt32);
        }

        public string GetString(string name)
        {
            return GetValue(name,reader.GetString);
        }

        public T GetValue<T>(string name)
        {
            return (T)reader.GetValue(reader.GetOrdinal(name));
        }

        public bool Read()
        {
            return reader.Read();
        }

        public T GetValue<T>(string name, Func<int, T> getter)
        {
            try
            {
                return getter(reader.GetOrdinal(name));
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new ColumnNotFoundException(name, ex);
            }
        }
    }
}
