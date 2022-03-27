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

        public IActionResult RoomDetail()
        {
            var result = _roomDetailService.GetRoomDetailById(1);

            return View(result);
        }
    }
}
