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
        //public IActionResult Index(int targetPrice, int wineRating)
        //{
            // Args above will go into GetWineList method



            // Return a RedirectToAction

        //}
    }
}
