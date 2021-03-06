using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using LocationData.Models;
using System.Data.SqlClient;
using System.Data;

namespace LocationData.DataDelegates
{
    internal class FetchPartInformationDataDelegate : DataReaderDelegate<IReadOnlyList<PartSearch>>
    {
        //private readonly string StreetAddress;
        private readonly string PartName;

        public FetchPartInformationDataDelegate(string partname)
            : base("AutoShop.FetchPartInformation")
        {
            //this.StreetAddress = streetaddress;
            this.PartName = partname;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            //var p = command.Parameters.Add("StreetAddress", SqlDbType.NVarChar);
            //p.Value = StreetAddress;
            var p = command.Parameters.Add("PartName", SqlDbType.NVarChar);
            p.Value = PartName;

        }

        public override IReadOnlyList<PartSearch> Translate(SqlCommand command, IDataRowReader reader)
        {
            //if (!reader.Read())
                //throw new RecordNotFoundException(StreetAddress);
            if (!reader.Read())
                throw new RecordNotFoundException(PartName);


            var temp = new List<PartSearch>();
            while (reader.Read())
            {
               temp.Add( new PartSearch(
                //StreetAddress,
                //PartName,
                reader.GetInt32("Quantity"),
                reader.GetString("Price"),
                reader.GetString("StreetAddress")
                )
                );
            }
            return temp;
        }

        /*
            @StreetAddress NVARCHAR(255),
            @PartName NVARCHAR(64)
            As
            SELECT S.Quantity, P.Price
            */
    }
}
