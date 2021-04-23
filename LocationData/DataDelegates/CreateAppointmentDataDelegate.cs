using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace LocationData.DataDelegates
{
    internal class CreateAppointmentDataDelegate :NonQueryDataDelegate<Appointment>
    {
        /*
        CustomerID int identity,
        LocationID int,
        RepairID int,
        Datetime Datetime2
        */
        //public readonly int CustomerID;
        //public readonly int LocationID;
        //public readonly int RepairID;
        public readonly DateTime dateTime;

        public CreateAppointmentDataDelegate(DateTime dateTime)
            : base("Location.CreateAppointment")
        {
            this.dateTime = dateTime;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CustomerID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("LocationID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("RepairID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("DateTime", SqlDbType.DateTime2);
            p.Value = dateTime;
        }

        public override Appointment Translate(SqlCommand command)
        {
            return new Appointment( (int)command.Parameters["CustomerID"].Value,
                                    (int)command.Parameters["LocationID"].Value,
                                    (int)command.Parameters["RepairID"].Value,
                                    dateTime
                                    );
        }
    }
}
