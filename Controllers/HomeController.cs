using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectMvcNet.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMvcNet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data = DateTime.Now.Hour;
            if (data >= 6 && data < 12)
            {
                ViewData["Reception"] = "Good Morning!";
            }
            else if (data > 12 && data < 18)
            {
                ViewData["Reception"] = "Good Afternoon!";
            }
            else
            {
                ViewData["Reception"] = "Good Evening!";
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Models.ViewModels.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
