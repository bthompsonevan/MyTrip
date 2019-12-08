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
        List<User> Users { get; }
        List<Trip> Trips { get; }
        void AddUser(User user);
        void AddTrip(Trip trip);
        User GetUserByUserName(string userName);
        void AddTripToUser(User user, Trip trip);
        void AddStopToTrip(Trip trip, TripStop tripStop);
        void AddAttendeeToTrip(Trip trip, TripAttendee tripAttendee);

    }
}
