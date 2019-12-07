using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrip.Models
{
    public class TripStop
    {
        public int TripStopID { get; set; }
        public string StopName { get; set; }
        public DateTime StopBegin {get;set;}
        public DateTime StopEnd { get; set; }
    }
}
