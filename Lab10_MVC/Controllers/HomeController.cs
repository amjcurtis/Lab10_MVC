using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10_MVC.Controllers
{
    public class HomeController : Controller
    {
        // First 'Index' action
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // Second 'Index' action
        //[HttpPost]
        //public IActionResult Index(decimal winePrice, int pointRating)
        //{
        //    // Determine what the params above will go into


        //    // Return a RedirectToAction

        //}
    }
}
