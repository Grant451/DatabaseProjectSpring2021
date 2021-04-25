using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using LocationData.Models;
using System.Data;

namespace LocationData
{
    internal class FetchAllLocationsAddressDataDelegate : DataReaderDelegate<IReadOnlyList<SalesObj>>
    {
        private int blank;

        public FetchAllLocationsAddressDataDelegate(int blank)
            : base("AutoShop.FetchAllLocationsAddress")
        {
            this.blank = blank;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<SalesObj> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<SalesObj>();
            while (reader.Read())
            {
                temp.Add(new SalesObj(
                            reader.GetString("StreetAddress")
                            )
                        );
            }
            return temp;
        }
    }
}