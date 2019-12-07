using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrip.Models
{
    public class User
    {
        private List<Trip> userTrips = new List<Trip>();

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }

        //TODO: User should have a list of trips that they are hosting
        public List<Trip> UserTrips { get { return userTrips; } }
    }
}
