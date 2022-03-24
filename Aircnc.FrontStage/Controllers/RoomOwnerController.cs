using Aircnc.FrontStage.Models.ViewModels.RoomOwner;
using Aircnc.FrontStage.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class RoomOwnerController : Controller
    {
        private readonly RoomOwnerService _RoomOwnerService;
        public RoomOwnerController(RoomOwnerService RoomOwnerService)
        {
            _RoomOwnerService = RoomOwnerService;


        }
        //RoomOwnerRoomList(int userid)
        public IActionResult RoomOwnerRoomList()
        {
            //先假裝是一
            var userid = 1;
            var result =
                _RoomOwnerService.GetAllRoomByOwnerId(userid).Select(roomOwnerDto=>new RoomOwnerViewModel
                { 
                    RoomOwnerDto = roomOwnerDto

                });

            return View(result);
        }
    }
}
