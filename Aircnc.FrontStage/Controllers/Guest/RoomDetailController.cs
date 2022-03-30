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

        // 以下測試
        public IActionResult RoomDetail()
        {
            var result = _roomDetailService.GetRoomDetailById(2);
            var room = new RoomDetailViewModel()
            {
                RoomId = result.RoomId,
                District = result.District,
                City = result.City,
                RoomName = result.RoomName,
                RoomCount = result.RoomCount,
                BedCount = result.BedCount,
                BathroomCount = result.BathroomCount,
                RoomDescription = result.RoomDescription
            };

            return View(room);
        }
    }
}
