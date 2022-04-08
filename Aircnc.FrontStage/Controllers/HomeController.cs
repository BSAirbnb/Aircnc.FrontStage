using Aircnc.FrontStage.Models;
using Aircnc.FrontStage.Models.ViewModels.Guest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Index(SearchVM input)
        {
            if (ModelState.IsValid)
            {
                TempData["location"] = input.NavSearch.Location;
                TempData["startDate"] = input.NavSearch.StartDate;
                TempData["endDate"] = input.NavSearch.EndDate;
                TempData["numberOfGuests"] = input.NavSearch.NumberOfGuests;
                return RedirectToAction("Search", "Search");
            }
            return NotFound();
        }

        public IActionResult Index()
        {
            int userId = int.Parse(User.Identity.Name);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
