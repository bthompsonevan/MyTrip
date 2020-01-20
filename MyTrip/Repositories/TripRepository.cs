using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyTrip.Models;


namespace MyTrip.Repositories
{
    public class TripRepository : ITripRepository
    {
        private AppDbContext context;

       

       // public List<AppUser> Users { get { return context.Users.ToList(); } }
        public List<Trip> Trips { get { return context.Trips.ToList(); } }

        public List<AppUser> Users => throw new NotImplementedException();

        public TripRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }

        public void AddUser(AppUser user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
       
        //public AppUser GetUserByUserName(string userName)
        //{
        //    AppUser user;
        //    user = context.Users.First(b => b.UserName == userName);
                   
        //    return ;
        //}

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

        public void AddTripToUser(AppUser user, Trip trip)
        {
            user.Trips.Add(trip);
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
