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

        public SalesObj(int sales, string streetAddress)
        {
            Sales = sales;
            StreetAddress = streetAddress;
        }

        public SalesObj(double sales)
        {
            Sales = sales;
        }
    }
}
