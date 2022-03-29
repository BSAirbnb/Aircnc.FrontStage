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
        private readonly HostHomePageService _hostHomePageService;
        public RoomOwnerController(HostListService hostListService, HostReservationService hostReservationService, HostHomePageService hostHomePageService)
        {
            _hostListService = hostListService;
            _hostReservationService = hostReservationService;
            _hostHomePageService = hostHomePageService;
        }

        /// <summary>
        /// 管理房源
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 預定
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 房東主頁 - 今天
        /// </summary>
        /// <param name="Hostid"></param>
        /// <returns></returns>
        public IActionResult HostHomePageReservation(int Hostid)
        {
            Hostid = 1;
            var reservation = _hostHomePageService.GetHostHomePagesReservation(Hostid).Select(homePageReservation => new HostHomePageViewModel
            {
                Status = homePageReservation.Status,
                RoomName = homePageReservation.RoomName,
                GuestName = homePageReservation.GuestName,
                During = $"{homePageReservation.CkeckIn} - {homePageReservation.CkeckOut}"
            });
            return View(reservation);
        }
    }
}
