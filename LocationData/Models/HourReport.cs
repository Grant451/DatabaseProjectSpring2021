using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class HourReport
    {
        public string EmployeeName { get; }

        public DateTime Hours { get; }//might be datetime2

        public string StreetAddress { get; }

        public HourReport(string empName, DateTime hours, string streetAddress)
        {
            EmployeeName = empName;
            Hours = hours;
            StreetAddress = streetAddress;
        }
    }
}
