using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class SalesObj
    {
        public double Sales { get; }

        public string StreetAddress { get; }

        public int Year { get; }

        //constructor for q23:
        public SalesObj(string streetAddress, int year, double sales)
        {
            Sales = sales;
            Year = year;
            StreetAddress = streetAddress;
        }

        public SalesObj(double sales, string streetAddress)
        {
            Sales = sales;
            StreetAddress = streetAddress;
        }

        public SalesObj(double sales)
        {
            Sales = sales;
        }

        public SalesObj(string streetAddress)
        {
            StreetAddress = streetAddress;
        }
    }
}
