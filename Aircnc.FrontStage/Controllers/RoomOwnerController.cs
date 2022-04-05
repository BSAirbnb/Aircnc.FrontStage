﻿using Aircnc.FrontStage.Models.Dtos.RoomOwner;
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
        private readonly HostListService _hostListService;
        private readonly HostReservationService _hostReservationService;
        private readonly HostHomePageService _hostHomePageService;
        private readonly CreateRoomService _createRoomService;

        private readonly HostRoomEditService _hostRoomEditService;
        public RoomOwnerController(HostListService hostListService, HostReservationService hostReservationService, HostHomePageService hostHomePageService, CreateRoomService createRoomService, HostRoomEditService hostRoomEditService)
        {
            _hostListService = hostListService;
            _hostReservationService = hostReservationService;
            _hostHomePageService = hostHomePageService;
            _hostRoomEditService = hostRoomEditService;
            _createRoomService = createRoomService;
        }

        /// <summary>
        /// 管理房源
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public IActionResult HostList(int hostId)
        {
            //先假設user1的房源
            hostId = 1;
            var result =
                _hostListService.GetAllRoomByOwnerId(hostId).Select(RoomOwnerDto => new HostListViewModel
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
        public IActionResult HostReservation(int hostid)
        {
            hostid = 1;
            var reservation = _hostReservationService.GetHostReservation(hostid).Select(HostReservation => new HostReservationViewModel
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


        /// <summary>
        /// 房源編輯列表
        /// </summary>
        /// <param name="hostid"></param>
        /// <returns></returns>
        public IActionResult HostRoomEditList(int roomId)
        {
            roomId = 1;
            var result = _hostRoomEditService.GetRoomDetail(roomId).Select(roomEditList => new HostRoomEditViewModel
            {
                RoomId = roomId,
                RoomName = roomEditList.RoomName,
                RoomDescription = roomEditList.RoomDescription,
                RoomGusetCount = roomEditList.RoomGusetCount,
                RoomStatus = roomEditList.RoomStatus, //房源狀態
                RoomService = roomEditList.RoomService, //房源設備
                Address = roomEditList.Country + roomEditList.City + roomEditList.District + roomEditList.Street,
                HouseType = roomEditList.HouseType, //房源類型
                RoomType = roomEditList.RoomType, //房間類型
                BedCount = roomEditList.BedCount, //床數
                RoomCount = roomEditList.RoomCount,  //臥室
                BathroomCount = roomEditList.BathroomCount, //衛浴
                UnitPrice = roomEditList.UnitPrice,
                RoomCheckInTime = roomEditList.RoomCheckInTime, //入住時段
                RoomCheckOutTime = roomEditList.RoomCheckOutTime  //退房時間
            });
            return View(result);
        }

        [HttpGet]
        //int Hostid = 1
        public IActionResult CreateRoom()
        {

            return View();
        }
        [HttpPost]
        //int Hostid = 1 
        public IActionResult CreateRoom([FromBody] CreateRoomDataModel request)
        {

            var result = _createRoomService.CreateRoom(request);

            if (!result.IsSuccess)
            {
                return new JsonResult("未加入成功");
            }

            return new JsonResult("加入房源成功");
        }
    }
}
