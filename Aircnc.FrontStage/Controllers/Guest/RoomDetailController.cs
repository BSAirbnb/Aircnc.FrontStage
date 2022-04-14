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
            //int userId = int.Parse(User.Identity.Name);

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
            return View(result);
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
