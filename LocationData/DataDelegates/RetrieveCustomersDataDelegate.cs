using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccess;
using LocationData.Models;

namespace LocationData
{
    internal class RetrieveCustomersDataDelegate : DataReaderDelegate<IReadOnlyList<Customer>>
    { 
        public RetrieveCustomersDataDelegate()
            : base("Location.RetrieveCustomers")
        {
        }

        public override IReadOnlyList<Customer> Translate(SqlCommand command, IDataRowReader reader)
        {
            var temp = new List<Customer>();

            while(reader.Read())
            {
                temp.Add(
                    new Customer(
                        reader.GetInt32("CustomerID"),
                        reader.GetString("CustomerName"),
                        reader.GetString("VinNumber")
                        )
                    );
            }
            return temp;
        }
    }
}