using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LocationData.Models;
using DataAccess;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace LocationData.DataDelegates
{
    internal class CreateAppointmentDataDelegate :NonQueryDataDelegate<Appointment>
    {
        /*
        AppointmentId INT NOT NULL IDENTITY(1, 1),
        LocationId INT NOT NULL,
        RepairId INT NOT NULL,
        CustomerId INT NOT NULL,
        AppointmentTime DATETIME2(0) NOT NULL,
        */

        public readonly int LocationID;
        public readonly int RepairID;
        public readonly int CustomerID;
        public readonly DateTime AppointmentTime;

        public CreateAppointmentDataDelegate(int locationID, int repairID, int customerID, DateTime dateTime)
            : base("AutoShop.CreateAppointment")
        {
            this.LocationID = locationID;
            this.RepairID = repairID;
            this.CustomerID = customerID;
            this.AppointmentTime = dateTime;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            //var p = command.Parameters.Add("AppointmentID", SqlDbType.Int);
            //p.Direction = ParameterDirection.Output;
            var p = command.Parameters.Add("LocationID", SqlDbType.Int);
            p.Value = LocationID;
            p = command.Parameters.Add("RepairID", SqlDbType.Int);
            p.Value = RepairID;
            p = command.Parameters.Add("CustomerID", SqlDbType.Int);
            p.Value = CustomerID;
            p = command.Parameters.Add("AppointmentTime", SqlDbType.DateTime2);
            p.Value = AppointmentTime;
        }

        public override Appointment Translate(SqlCommand command)
        {
            return new Appointment( //(int)command.Parameters["AppointmentID"].Value,
                                    LocationID,
                                    RepairID,
                                    CustomerID,
                                    AppointmentTime
                                    );
        }
    }
}
