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
        List<Trip> Trips { get; }
        void AddTrip(Trip trip);
        void AddTripToUser(User user, Trip trip);

    }
}
