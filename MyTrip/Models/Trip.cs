using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyTrip.Models
{
    public class Trip
    {
        private List<TripAttendee> tripAttendees = new List<TripAttendee>();
        private List<TripStop> tripStops = new List<TripStop>();

        public int TripID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 1)]
        public string TripName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy")]
        public DateTime TripStartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy")]
        public DateTime TripEndDate { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 1)]
        public string TripDestination { get; set; }   //  The overall location
        public int UserID { get; set; }
      
        public List<TripAttendee> TripAttendees { get { return tripAttendees; } }
        public List<TripStop> TripStops { get { return tripStops; } }

    }
}
