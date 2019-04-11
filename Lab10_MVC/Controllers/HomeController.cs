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
			Wine wine = new Wine();
			wine.Price = targetPrice;
			wine.Points = pointRating;

			return RedirectToAction("Results", wine);
		}

		// 'Results' action
		[HttpGet]
		public IActionResult Results(int targetPrice, int pointRating)
		{
			return View(GetWineList(targetPrice, pointRating));
		}
	}
	}
