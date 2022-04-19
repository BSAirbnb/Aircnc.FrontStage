using Aircnc.FrontStage.Models.ViewModels.Guest;
using Microsoft.AspNetCore.Mvc;
using Aircnc.FrontStage.Services.Guest;
using System.Linq;

namespace Aircnc.FrontStage.Controllers.Guest
{
    public class BookingController : Controller
    {
        private readonly RoomDetailService _roomDetailService;
        public BookingController(RoomDetailService roomDetailService)
        {
            _roomDetailService = roomDetailService;
        }
        public IActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Booking(SearchVM input)
        {
            if (TempData["roomId"] != null) { var roomId = (int)TempData["roomId"]; }
            if (ModelState.IsValid)
            {
                int roomId = 22;
                var room = _roomDetailService.GetRoomDetailById(roomId);
                var detail = new RoomDetailViewModel()
                {
                    OwnerName = room.OwnerName,
                    RoomType = room.RoomType,
                    HouseType = room.HouseType,
                    District = room.District,
                    City = room.City,
                    RoomName = room.RoomName,
                    AvgStars = room.AvgStars,
                    ReviewsCount = room.Reviews.Count
                };
                input.RoomDetailVM = detail;
            }
            return View(input);
        }
    }
}
