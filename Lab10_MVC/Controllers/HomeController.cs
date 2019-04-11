using Lab10_MVC.Classes;
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
		public IActionResult Index(int targetPrice, int pointRating)
		{
			return RedirectToAction("Results", new { targetPrice, pointRating });
		}

		// 'Results' action
		[HttpGet]
		public IActionResult Results(int targetPrice, int pointRating)
		{
			return View(GetWineList(targetPrice, pointRating));
		}
	}
	}
