using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.ViewModels.Guest;
using Aircnc.FrontStage.Services.Guest;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
            var result = _searchRoomService.GetRoom(location).Select(SearchRoomDto => new SearchRoomViewModel
            {
                RoomId = SearchRoomDto.RoomId,
                UserId = SearchRoomDto.UserId,
                HouseType = SearchRoomDto.HouseType,
                RoomType = SearchRoomDto.RoomType,
                Status = SearchRoomDto.Status,
                RoomName = SearchRoomDto.RoomName,
                Pax = SearchRoomDto.Pax,
                RoomCount = SearchRoomDto.RoomCount,
                BedCount = SearchRoomDto.BedCount,
                BathroomCount = SearchRoomDto.BathroomCount,
                Country = SearchRoomDto.Country,
                City = SearchRoomDto.City,
                District = SearchRoomDto.District,
                UnitPrice = SearchRoomDto.UnitPrice,
            });
            return View(result);
        }
    }
}
