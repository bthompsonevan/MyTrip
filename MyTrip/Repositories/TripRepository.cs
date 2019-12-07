using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTrip.Models;

namespace MyTrip.Repositories
{
    public class TripRepository : ITripRepository
    {
        private AppDbContext context;

        public List<Trip> Trips { get { return context.Trips.ToList(); } }
       
        public TripRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddTrip(Trip trip)
        {
            context.Trips.Add(trip);
            context.SaveChanges();
        }

        public void AddAttendee(Trip trip, TripAttendee tripAttendee)
        {
            trip.TripAttendees.Add(tripAttendee);
            context.Trips.Update(trip);
            context.SaveChanges();
        }
    }
}
