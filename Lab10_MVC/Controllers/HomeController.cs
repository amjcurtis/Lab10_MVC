using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab10_MVC.Controllers
{
    public class HomeController : Controller
    {
        // 'Index' action
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
