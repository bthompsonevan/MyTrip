using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTrip.Repositories;
using MyTrip.Models;

namespace MyTrip.Repositories
{
    public interface ITripRepository
    {
        List<AppUser> Users { get; }
      //  List<Trip> Trips { get; }
        void AddUser(AppUser user);
        void AddTrip(Trip trip);
       // AppUser GetUserByUserName(string userName);
        void AddTripToUser(AppUser user, Trip trip);
        void AddStopToTrip(Trip trip, TripStop tripStop);
        void AddAttendeeToTrip(Trip trip, TripAttendee tripAttendee);

    }
}
