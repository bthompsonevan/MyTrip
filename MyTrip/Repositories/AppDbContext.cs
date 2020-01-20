using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyTrip.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {

        public AppDbContext(
            DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripAttendee> TripAttendees { get; set; }
        //public DbSet<AppUser> Users { get; set; } // Not needed because of Identity
        public DbSet<TripStop> TripStops { get; set; }
    }
}
