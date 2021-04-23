using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess;
using System.Data;
using System.Data.SqlClient;
using LocationData.Models;

namespace LocationData.DataDelegates
{
    internal class CreateCustomerDataDelegate : NonQueryDataDelegate<Customer>
    {
        public readonly string CustomerName;
        public readonly string VinNumber;

        public CreateCustomerDataDelegate(string customerName, string vinNumber)
            : base("Location.CreateCustomer")
        {
            this.CustomerName = customerName;
            this.VinNumber = vinNumber;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("CustomerID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;

            p = command.Parameters.Add("CustomerName", SqlDbType.NVarChar);
            p.Value = CustomerName;

            p = command.Parameters.Add("VinNumber", SqlDbType.NVarChar);
            p.Value = VinNumber;
        }

        public override Customer Translate(SqlCommand command)
        {
            return new Customer((int)command.Parameters["CustomerID"].Value, CustomerName, VinNumber);
        }
    }
}
