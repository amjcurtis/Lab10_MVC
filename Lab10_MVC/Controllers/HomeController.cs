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
	   [HttpPost]
		public IActionResult Index(int TargetPrice, int WineRating)
		{
			//Args above will go into GetWineList method

			// 

			//Return a RedirectToAction


		}

		// 'Result' action
		[HttpGet]
		public IActionResult Results(int TargetPrice, int WineRating)
		{
			// Call method in parens of Results view
			return View(GetWineList(TargetPrice, WineRating));

		}
	}
}
