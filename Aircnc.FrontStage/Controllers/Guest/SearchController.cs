using Aircnc.FrontStage.Services.Guest;
using Microsoft.AspNetCore.Mvc;

namespace Aircnc.FrontStage.Controllers.Guest
{
    public class SearchController : Controller
    {
        private readonly SearchRoomService _searchRoomService;
        public SearchController(SearchRoomService searchRoomService)
        {
            _searchRoomService = searchRoomService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string location)
        {
            location = "台北市";
            var result = _searchRoomService.GetRoom(location);
            return View(result);
        }
    }
}
