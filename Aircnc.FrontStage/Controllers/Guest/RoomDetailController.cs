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
        public IActionResult RoomDetail(int roomId)
        {
            var room = _roomDetailService.GetRoomDetailById(roomId);
            var detail = new RoomDetailViewModel()
            {
                RoomId = room.RoomId,
                District = room.District,
                City = room.City,
                RoomName = room.RoomName,
                RoomCount = room.RoomCount,
                BedCount = room.BedCount,
                BathroomCount = room.BathroomCount,
                RoomDescription = room.RoomDescription
            };
            var result = new SearchVM() { RoomDetailVM = detail };
            return View(result);
        }
    }
}
