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
        
        public IActionResult RoomOwnerRoomList(int userid)
        {
            //先假設user1的房源
             userid = 1;
            var result =
                _RoomOwnerService.GetAllRoomByOwnerId(userid).Select(RoomOwnerDto=>new RoomOwnerViewModel
                { 
                    RoomOwnerDto = RoomOwnerDto


                });

            return View(result);
        }
    }
}
