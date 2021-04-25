using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationData.Models
{
    public class PopularApptTimes
    {
        public string StreetAddress { get; }

        public int MorningAppointments { get; }

        public int AfternoonAppointments { get; }

        public int EveningAppointments { get; }

        public PopularApptTimes(string streetAddress, int morningAppointments, int afternoonAppointments, int eveningAppointments)
        {
            StreetAddress = streetAddress;
            MorningAppointments = morningAppointments;
            AfternoonAppointments = afternoonAppointments;
            EveningAppointments = eveningAppointments;
        }
    }
}
