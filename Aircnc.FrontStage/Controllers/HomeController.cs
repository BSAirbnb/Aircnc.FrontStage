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
            if (ModelState.IsValid && input.NavSearch.Location != null)
            {
                if (input.NavSearch.StartDate != null) 
                { 
                    var startDate = (DateTime)input.NavSearch.StartDate; 
                    TempData["startDate"] = startDate.ToShortDateString();
                }
                if (input.NavSearch.EndDate != null) 
                { 
                    var endDate = (DateTime)input.NavSearch.EndDate;
                    TempData["endDate"] = endDate.ToShortDateString();
                }
                TempData["location"] = input.NavSearch.Location;                
                TempData["numberOfGuests"] = input.NavSearch.NumberOfGuests;
                return RedirectToAction("Search", "Search");
            }
            return NotFound();
        }

        public IActionResult Index()
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
