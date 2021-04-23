using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using DatabaseProjectSpring2021;
using LocationData.Models;
using LocationData.DataDelegates;


namespace LocationData
{
    public class SqlLocationRepository : ILocationRepository
    {
        private readonly SqlCommandExecutor executor;

        public SqlLocationRepository(string connectionString)
        {
            executor = new SqlCommandExecutor(connectionString);
        }

        public Appointment CreateAppointment(DateTime dateTime)
        {
            if(dateTime == null)
            {
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(dateTime));
            }
            var d = new CreateAppointmentDataDelegate(dateTime);
            return executor.ExecuteNonQuery(d);
        }

        public Customer CreateCustomer(string customerName, string vinNumber)
        {
            if (string.IsNullOrWhiteSpace(customerName))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(customerName));
            if (string.IsNullOrWhiteSpace(vinNumber))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(vinNumber));
            var d = new CreateCustomerDataDelegate(customerName, vinNumber);
            return executor.ExecuteNonQuery(d);
        }

        public Location CreateLocation(string StreetAddress, string City, string Region, string Zip)
        {
            if (string.IsNullOrWhiteSpace(StreetAddress))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(StreetAddress));
            if (string.IsNullOrWhiteSpace(City))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(City));
            if (string.IsNullOrWhiteSpace(Region))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Region));
            if (string.IsNullOrWhiteSpace(Zip))
                throw new ArgumentException("The parameter cannot be null or empty.", nameof(Zip));
            var d = new CreateLocationDataDelegate(StreetAddress, City, Region, Zip);
            return executor.ExecuteNonQuery(d);
        }

        public Location FetchLocation(int LocationID)
        {
            var d = new FetchLocationDataDelegate(LocationID);
            return executor.ExecuteReader(d);
        }

        public Location GetLocation(string email)
        {
            var d = new GetLocationDataDelegate(email);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<Location> RetrieveLocations()
        {
            return executor.ExecuteReader(new RetrieveLocationsDataDelegate());
        }

       
    }
}
