using Lab10_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10_MVC.Controllers
{
    public class HomeController : Controller
    {
		/// <summary>
		/// First 'Index' action
		/// </summary>
		/// <returns>Home view</returns>
		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

		/// <summary>
		/// Second 'Index' action
		/// </summary>
		/// <param name="targetPrice">max wine price</param>
		/// <param name="pointRating">min wine rating</param>
		/// <returns>redirects to Results view</returns>
		[HttpPost]
		public IActionResult Index(int targetPrice, int pointRating)
		{
			return RedirectToAction("Results", new { targetPrice, pointRating });
		}

		/// <summary>
		/// 'Results' action
		/// </summary>
		/// <param name="targetPrice">max wine price</param>
		/// <param name="pointRating">min wine rating</param>
		/// <returns>Results view</returns>
		[HttpGet]
		public IActionResult Results(int targetPrice, int pointRating)
		{
			return View(Wine.GetWineList(targetPrice, pointRating));
		}
	}
}
