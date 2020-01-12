using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyTrip.Models;
using MyTrip.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace MyTrip.Controllers
{
    public class UserHomeController : Controller
    {
        
        ITripRepository repo;
        public UserHomeController(ITripRepository r)
        {
            repo = r;
        }

        //, List<Trip> usersTrips  was experimenting with this earlier
        public IActionResult UserHomeScreen(User user)
        {
            //Once we learn logins update this code so it is not semi-hardcoded. 
            user = repo.GetUserByUserName(repo.Users[0].UserName);
            List<Trip> userTrips = new List<Trip>();
            userTrips = repo.Trips;

            foreach (Trip t in userTrips)
            {
                if (user.UserID == t.UserID)
                {
                    user.Trips.Add(t);
                }
            }

            return View("UserHomeScreen", user);
        }
       
        public ViewResult UserLogInScreen()
        {
            return View();
        }

        [HttpPost]
        public ViewResult UserLogInScreen(string userName)
        {
            string passedValue = repo.GetUserByUserName(userName).UserName;

            if (userName == passedValue)
            {
                
                User user = repo.GetUserByUserName(userName);
                
                return View("UserHomeScreen", user);
            }
            else
            {
                return View("CreateUser");
            }
                
        }        

        public ViewResult ContactUs()
        {
            return View();
        }

        /* **********************************
        *   CREATE USER ACTION METHODS     *     //Trying this out to see if it helps visability
        ************************************/
        public ViewResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ViewResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                repo.AddUser(user);
                return View("UserHomeScreen", user);
            }
            else
            {
                return View();
            }
        }

        /* **********************************
         *  TRIP ATTENDEE ACTION METHODS    *     
         ************************************/
        public ViewResult InviteAttendee()
        {
                      
            return View();
        }

        [HttpPost]
        public ViewResult InviteAttendee(Trip trip, User user, TripAttendee tripAttendee)
        {
            
            user = repo.GetUserByUserName(repo.Users[0].UserName);
            //TODO: get logic to associate a trip
            //Getting an out of range exception error  --- I think it is not transferring the trips again
            //repo.AddAttendeeToTrip(user.Trips[0], tripAttendee);
            return View("UserHomeScreen", user);
        }

        /* **********************************
        *   CURRENT TRIP ACTION METHODS     *     
        ************************************/
        public ViewResult CurrentTrips(User user, List<Trip> usersTrips)
        {

            user = repo.GetUserByUserName(repo.Users[0].UserName);
            int usersID = user.UserID;
            usersTrips = repo.Trips;
            List<Trip> updatedTrips = new List<Trip>();

            foreach (Trip t in usersTrips)
            {

                if (user.UserID == t.UserID)
                {
                    updatedTrips.Add(t);
                }
            }

            return View(updatedTrips);
        }

        /* **********************************
        *     ADD TRIP ACTION METHODS      *     
        ************************************/
        public ViewResult AddTrip()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddTrip(Trip trip, User user)
        {
            user = repo.GetUserByUserName(repo.Users[0].UserName);
            user.Trips.Add(trip);
            repo.AddTripToUser(user, trip);
            return View("UserHomeScreen", user);
        }

     
    }
}