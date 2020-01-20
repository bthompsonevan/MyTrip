using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTrip.Models;

namespace MyTrip.Repositories
{
    public class FakeTripRepository : ITripRepository
    {
        private List<AppUser> users = new List<AppUser>();
        public List<AppUser> Users { get { return users; } }

        private List<Trip> trips = new List<Trip>();
        public List<Trip> Trips { get { return trips; } }

        public void AddUser(AppUser user)
        {
           users.Add(user);            
        }

        public void AddTrip(Trip trip)
        {
            trips.Add(trip);           
        }

        public void AddTripToUser(AppUser user, Trip trip)
        {
            user.Trips.Add(trip);           
            
        }

        public AppUser GetUserByUserName(string userName)
        {
            AppUser user;
            user = Users.First(b => b.UserName == userName);
            return user;
        }

        public void AddStopToTrip(Trip trip, TripStop tripStop)
        {
            trip.TripStops.Add(tripStop);
        }

        public void AddAttendeeToTrip(Trip trip, TripAttendee tripAttendee)
        {
            trip.TripAttendees.Add(tripAttendee);
        }

    }
}
