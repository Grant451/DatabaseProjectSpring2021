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
        //(StreetAddress, RepairName, CustomerName, AppointmentTime)

        public readonly string StreetAddress;
        public readonly string RepairName;
        public readonly string CustomerName;
        public readonly DateTime AppointmentTime;

        public CreateAppointmentDataDelegate(string streetAddress, string repName, string custName, DateTime dateTime)
            : base("AutoShop.CreateAppointment")
        {
            this.StreetAddress = streetAddress;
            this.RepairName = repName;
            this.CustomerName = custName;
            this.AppointmentTime = dateTime;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            //var p = command.Parameters.Add("AppointmentID", SqlDbType.Int);
            //p.Direction = ParameterDirection.Output;
            var p = command.Parameters.Add("StreetAddress", SqlDbType.NVarChar);
            p.Value = StreetAddress;
            p = command.Parameters.Add("RepairName", SqlDbType.NVarChar);
            p.Value = RepairName;
            p = command.Parameters.Add("CustomerName", SqlDbType.NVarChar);
            p.Value = CustomerName;
            p = command.Parameters.Add("AppointmentTime", SqlDbType.DateTime2);
            p.Value = AppointmentTime;
        }

        public override Appointment Translate(SqlCommand command)
        {
            return new Appointment( //(int)command.Parameters["AppointmentID"].Value,
                                    StreetAddress,
                                    RepairName,
                                    CustomerName,
                                    AppointmentTime
                                    );
        }
    }
}
