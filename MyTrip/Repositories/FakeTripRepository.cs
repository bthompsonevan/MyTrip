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

        public void AddUser(User user)
        {
           users.Add(user);            
        }

        public void AddTrip(Trip trip)
        {
            trips.Add(trip);           
        }

        public void AddTripToUser(User user, Trip trip)
        {
            user.Trips.Add(trip);           
            
        }

        public User GetUserByUserName(string userName)
        {
            User user;
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
