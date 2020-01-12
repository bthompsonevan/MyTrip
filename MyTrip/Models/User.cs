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
        [Required(ErrorMessage = "User Name is required")]
        [StringLength(20, MinimumLength = 3)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(15, MinimumLength = 8)]
        //Possibly add a regex here for special characters/uppercase and lowercase requirements??
        public string Password { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(1000, MinimumLength = 3)]
        public string Bio { get; set; }

        public List<Trip> Trips { get { return trips; } }
    }
}
