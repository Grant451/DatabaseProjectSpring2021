using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchSalesDataDelegate : DataReaderDelegate<IReadOnlyList<SalesObj>>
    {
        private int blank;

        public FetchSalesDataDelegate(int blank)
            : base("AutoShop.FetchSales")
        {
            this.blank = blank;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
            //takes no params
        }

        public override IReadOnlyList<SalesObj> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<SalesObj>();

            while (reader.Read())
            {
                temp.Add(new SalesObj(
                                reader.GetDouble("Sales"),
                                reader.GetString("StreetAddress")
                   ));
            }

            return temp;
        }
    }
}