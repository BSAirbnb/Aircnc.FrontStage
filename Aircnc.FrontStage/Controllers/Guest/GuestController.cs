using Aircnc.FrontStage.Services.Guest;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aircnc.FrontStage.Models.ViewModels;

namespace Aircnc.FrontStage.Controllers
{
    public class GuestController : Controller
    {
        private readonly NavSearchService _navSearchService;
        public GuestController(NavSearchService navSearchService)
        {
            _navSearchService = navSearchService;
        }
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult NavSearch(NavSearchViewModel input)
        //{
        //    var viewModelSearch = new NavSearchViewModel()
        //    {
        //        Location = input.Location,
        //        StartDate = input.StartDate,
        //        EndDate = input.EndDate,
        //        NumberOfGuests = input.NumberOfGuests
        //    };

        //    var result = _navSearchService.GetResult(viewModelSearch);
        //    return RedirectToAction("SearchRoom", "SearchController", result);
        //}

        public IActionResult RecommendedDestination()
        {

            return View();
        }
    }
}
