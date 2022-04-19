﻿using Aircnc.FrontStage.Models.ViewModels.Guest;
using Microsoft.AspNetCore.Mvc;
using Aircnc.FrontStage.Services.Guest;
using System.Linq;

namespace Aircnc.FrontStage.Controllers.Guest
{
    public class BookingController : Controller
    {
        private readonly RoomDetailService _roomDetailService;
        private readonly AverageRoomPriceService _averageRoomPriceService;
        public BookingController(RoomDetailService roomDetailService, AverageRoomPriceService averageRoomPriceService)
        {
            _roomDetailService = roomDetailService;
            _averageRoomPriceService = averageRoomPriceService;
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

                input.RoomDetailVM.UnitPrice = _averageRoomPriceService.FindPrice(roomId, input.roomDetailPost.startDate, input.roomDetailPost.endDate);
            }
            return View(input);
        }
    }
}
