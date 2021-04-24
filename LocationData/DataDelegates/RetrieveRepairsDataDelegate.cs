using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using LocationData.Models;
using System.Data.SqlClient;

namespace LocationData.DataDelegates
{
    internal class RetrieveRepairsDataDelegate : DataReaderDelegate<IReadOnlyList<Repair>>
    {
        public RetrieveRepairsDataDelegate()
            : base("Location.RetrieveRepairs")
        {
        }

        public override IReadOnlyList<Repair> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<Repair>();
            while(reader.Read())
            {
                temp.Add(new Repair(
                    reader.GetInt32("RepairID"),
                    reader.GetString("RepairName"),
                    reader.GetString("LaborCost"),
                    reader.GetString("Status")
                    ));
            }
            return temp;
        }
    }
}
