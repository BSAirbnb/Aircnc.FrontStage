using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.ViewModels.Guest;
using Aircnc.FrontStage.Services.Guest;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers.Guest
{
    public class RoomDetailController : Controller
    {
        private readonly RoomDetailService _roomDetailService;
        public RoomDetailController(RoomDetailService roomDetailService)
        {
            _roomDetailService = roomDetailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult RoomDetail(int roomId)
        {
            TempData["roomId"] = roomId;

            var room = _roomDetailService.GetRoomDetailById(roomId);
            var detail = new RoomDetailViewModel()
            {
                OwnerName = room.OwnerName,
                OwnerCreateTime = room.OwnerCreateTime,
                OwnerReviewsCount = room.OwnerReviewsCount,

                RoomId = room.RoomId,
                RoomType = room.RoomType,
                HouseType = room.HouseType,
                District = room.District,
                City = room.City,
                RoomName = room.RoomName,
                RoomCount = room.RoomCount,
                BedCount = room.BedCount,
                BathroomCount = room.BathroomCount,
                RoomDescription = room.RoomDescription,

                ServiceLabels = room.ServiceLabels,
                Reviews = room.Reviews,
                AvgStars = room.AvgStars,
                ReviewsCount = room.Reviews.Count()
            };
            var result = new SearchVM() { RoomDetailVM = detail };

            //以 json 傳遞房源not available的時間
            ViewData["RoomAvailability"] = System.Text.Json.JsonSerializer.Serialize(room.roomAvailability);
            return View(result);
        }

        [HttpPost]
        public IActionResult RoomDetail(SearchVM input)
        {
            var startDate = input.roomDetailPost.startDate;
            var endDate = input.roomDetailPost.endDate;
            var guests = input.roomDetailPost.guestNumbers;

            return RedirectToAction("Booking", "Booking", input);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToWishList()
        {
            int roomId = (int)TempData["roomId"];
            int userId = int.Parse(User.Identity.Name);
            TempData["AddWishListResult"] = _roomDetailService.AddToWishListService(userId, roomId);
            return RedirectToAction(nameof(RoomDetail), new { roomId = roomId });
        }
    }
}
