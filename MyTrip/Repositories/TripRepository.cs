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

        public List<User> Users { get { return context.Users.ToList(); } }
        public List<Trip> Trips { get { return context.Trips.ToList(); } }
       
        public TripRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public User GetUserByUserName(string userName)
        {
            User user;
            user = context.Users.First(b => b.UserName == userName);
            return user;
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

        public void AddTripToUser(User user, Trip trip)
        {
            user.UserTrips.Add(trip);
            context.Users.Update(user);
            context.SaveChanges();
        }

        public void AddStopToTrip(Trip trip, TripStop tripStop)
        {
            trip.TripStops.Add(tripStop);
            context.Trips.Update(trip);
            context.SaveChanges();
        }

        public void AddAttendeeToTrip(Trip trip, TripAttendee tripAttendee)
        {
            trip.TripAttendees.Add(tripAttendee);
            context.Trips.Update(trip);
            context.SaveChanges();
        }
    }
}
