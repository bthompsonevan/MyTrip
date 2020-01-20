using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace MyTrip.Models
{
    public class AppUser : IdentityUser
    {
        private List<Trip> trips = new List<Trip>();        
        
        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 3)]
        public string Bio { get; set; }

        public List<Trip> Trips { get { return trips; } }
    }
}
