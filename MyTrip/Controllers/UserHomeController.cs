﻿using System;
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

        public IActionResult UserHomeScreen()
        {            
            return View();
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
            repo.AddUser(user);
            return View("UserHomeScreen", user);
        }

        /* **********************************
         *  TRIP ATTENDEE ACTION METHODS    *     
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

        /* **********************************
        *   CURRENT TRIP ACTION METHODS     *     
        ************************************/
        public ViewResult CurrentTrips()
        {
            return View();
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
            repo.AddTrip(trip);
            user.UserTrips.Add(trip);
            return View("UserHomeScreen", user);
        }

     
    }
}