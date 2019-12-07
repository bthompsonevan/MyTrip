using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTrip.Models;

namespace MyTrip.Repositories
{
    public class FakeTripRepository : ITripRepository
    {
        private List<User> users = new List<User>();
        public List<User> Users { get { return users; } }

        private List<Trip> trips = new List<Trip>();
        public List<Trip> Trips { get { return trips; } }

              

        public void AddTrip(Trip trip)
        {
            trips.Add(trip);           
        }

        public void AddTripToUser(User user, Trip trip)
        {
            user.UserTrips.Add(trip);           
            
        }

        public void AddTripStopToTrip(Trip trip, TripStop tripStop)
        {

        }

    }
}
