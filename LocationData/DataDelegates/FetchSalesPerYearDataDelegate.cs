using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchSalesPerYearDataDelegate : DataReaderDelegate<IReadOnlyList<SalesObj>>
    {
        private int blank6;

        public FetchSalesPerYearDataDelegate(int blank6)
            : base("AutoShop.FetchSalesPerYear")
        {
            this.blank6 = blank6;
        }

        public override IReadOnlyList<SalesObj> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<SalesObj>();
            while (reader.Read())
            {
                temp.Add(new SalesObj(
                    reader.GetString("StreetAddress"),
                    reader.GetInt32("Year"),
                    reader.GetDouble("Sales")
                          )
                    );
            }
            return temp;
        }
    }
}