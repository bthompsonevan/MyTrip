using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrip.Models
{
    public class Trip
    {
        public int TripID { get; set; }
        public string TripName { get; set; }
        public string TripStartDate { get; set; }
        public string TripEndDate { get; set; }
        public string TripDestination { get; set; }   //  The overall location
        public string TripStops { get; set; }   //TODOL should this be a list of stops?!?!?!

    }
}
