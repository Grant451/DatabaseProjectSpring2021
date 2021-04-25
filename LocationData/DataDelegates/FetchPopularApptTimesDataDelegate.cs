using DataAccess;
using LocationData.Models;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData
{
    internal class FetchPopularApptTimesDataDelegate : DataReaderDelegate<IReadOnlyList<PopularApptTimes>>
    {
        private int blank;

        public FetchPopularApptTimesDataDelegate(int blank)
            : base("AutoShop.FetchPopularApptTimes")
        {
            this.blank = blank;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);
        }

        public override IReadOnlyList<PopularApptTimes> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<PopularApptTimes>();
            while (reader.Read())
            {
                temp.Add(new PopularApptTimes(
                    reader.GetString("StreetAddress"),
                    reader.GetInt32("MorningAppointments"),
                    reader.GetInt32("AfternoonAppointments"),
                    reader.GetInt32("EveningAppointments")
                          )
                    );
            }
            return temp;
        }
    }
}