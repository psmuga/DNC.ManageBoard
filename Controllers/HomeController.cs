using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DNC.ManageBoard.Models;
using DNC.ManageBoard.Settings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

namespace DNC.ManageBoard.Controllers
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
            //_logger.LogCritical("Hello from Home Controller");
  
            return View();
        }

        [Authorize]
        public IActionResult About()
        {
            //_logger.LogInformation("Hello from about ");
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        [Authorize(Policy = "PolishOnly")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
