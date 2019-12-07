using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTrip.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyTrip.Controllers
{
    public class UserHomeController : Controller
    {
        public IActionResult UserHomeScreen()
        {
            return View();
        }

        public IActionResult UserLogInScreen()
        {
            return View();
        }

        [HttpPost]
        public ViewResult UserLogInScreen(User user)
        {
            return View("UserHomeScreen", user);
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }            
        /* **********************************
         *  TRIP ATTENDEE ACTION METHODS    *     //Trying this out to see if it helps visability
         ************************************/
        public ViewResult InviteAttendee()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InviteAttendee(Trip trip)
        {
            //TODO: decide where to go after TripAttendee has been added
            return View();
        }
    }
}