using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyTrip.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(
            DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripAttendee> TripAttendees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TripStop> TripStops { get; set; }
    }
}
