using Aircnc.FrontStage.Models.ViewModels.RoomOwner;
using Aircnc.FrontStage.Services;
using Aircnc.FrontStage.Services.RoomOwner;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class RoomOwnerController : Controller
    {
        private readonly HostListService  _hostListService;
        private readonly HostReservationService _hostReservationService;
        public RoomOwnerController(HostListService hostListService, HostReservationService hostReservationService)
        {
            _hostListService = hostListService;
            _hostReservationService = hostReservationService;
        }

        public IActionResult HostList(int userid)
        {
            //先假設user1的房源
             userid = 1;
            var result =
                _hostListService.GetAllRoomByOwnerId(userid).Select(RoomOwnerDto=>new HostListViewModel
                { 
                    HostListDto = RoomOwnerDto


                });

            return View(result);
        }

        public IActionResult HostReservation(int id)
        {
            id = 1;
            var reservation = _hostReservationService.GetHostReservation(id).Select(HostReservation => new HostReservationViewModel
            {
                RoomId = HostReservation.RoomId,
                OwnerId = HostReservation.OwnerId,
                GuestName = HostReservation.GuestName,
                Status = HostReservation.Status,
                BookingDateTime = HostReservation.BookingDateTime,
                CkeckIn = HostReservation.CkeckIn,
                CkeckOut = HostReservation.CkeckOut,
            });
            return View(reservation);
        }
    }
}
