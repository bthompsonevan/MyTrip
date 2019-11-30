using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrip.Models
{
    public class TripAttendee
    {
        public int TripAttendeeID { get; set; }
        public string AttendeeFirstName { get; set; }
        public string AttendeeLastName { get; set; }
        public string AttendeeEmail { get; set; }
    }
}
