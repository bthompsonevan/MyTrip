using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyTrip.Models
{
    public class User
    {
        private List<Trip> trips = new List<Trip>();

        public int UserID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }

        public List<Trip> Trips { get { return trips; } }
    }
}
