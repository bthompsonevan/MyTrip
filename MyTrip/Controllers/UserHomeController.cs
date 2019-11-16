using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyTrip.Controllers
{
    public class UserHomeController : Controller
    {
        public ViewResult UserHomeScreen()
        {
            return View();
        }
    }
}