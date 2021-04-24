using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using LocationData.Models;

namespace LocationData
{
    internal class RetrieveAppointmentsDataDelegate : DataReaderDelegate<IReadOnlyList<Appointment>>
    {
        public RetrieveAppointmentsDataDelegate()
            : base("Location.RetrieveAppointments")
        {
        }

        public override IReadOnlyList<Appointment> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<Appointment>();

            while(reader.Read())
            {
                temp.Add(
                    new Appointment(
                        reader.GetInt32("AppointmentID"),
                        reader.GetInt32("LocationID"),
                        reader.GetInt32("RepairID"),
                        reader.GetInt32("CustomerID"),
                        reader.GetDateTime("AppointmentTime")
                        )
                    );
            }
            return temp;
        }
    }
}