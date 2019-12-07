using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrip.Models
{
    public class Trip
    {
        private List<TripAttendee> tripAttendees = new List<TripAttendee>();
        private List<TripStop> tripStops = new List<TripStop>();

        public int TripID { get; set; }
        public string TripName { get; set; }
        public string TripStartDate { get; set; }
        public string TripEndDate { get; set; }
        public string TripDestination { get; set; }   //  The overall location
      
        public List<TripAttendee> TripAttendees { get { return tripAttendees; } }
        public List<TripStop> TripStops { get { return tripStops; } }

    }
}
