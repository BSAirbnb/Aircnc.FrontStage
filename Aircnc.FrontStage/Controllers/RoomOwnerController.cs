using Aircnc.FrontStage.Models.DataModels.RoomOwner;
using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.RoomOwner;
using Aircnc.FrontStage.Services;
using Aircnc.FrontStage.Services.RoomOwner;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class RoomOwnerController : Controller
    {
        private readonly HostListService _hostListService;
        private readonly HostReservationService _hostReservationService;
        private readonly HostHomePageService _hostHomePageService;
        private readonly CreateRoomService _createRoomService;
        private readonly CalendarService _calendarService;

        private readonly HostRoomEditService _hostRoomEditService;
        public RoomOwnerController(HostListService hostListService, HostReservationService hostReservationService, HostHomePageService hostHomePageService, CreateRoomService createRoomService, HostRoomEditService hostRoomEditService, CalendarService calendarService)
        {
            _hostListService = hostListService;
            _hostReservationService = hostReservationService;
            _hostHomePageService = hostHomePageService;
            _hostRoomEditService = hostRoomEditService;
            _createRoomService = createRoomService;
            _calendarService = calendarService;
        }

        /// <summary>
        /// 管理房源
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        /// 
        [Authorize]
        [HttpGet]
        public IActionResult HostList()
        {
            //先假設user1的房源
            int hostId = int.Parse(User.Identity.Name);
            var result = _hostListService.GetAllRoomByOwnerId(hostId).Select(RoomOwnerDto => new HostListViewModel
                {
                    RoomId = RoomOwnerDto.RoomId,
                    UserId = RoomOwnerDto.UserId,
                    Status = RoomOwnerDto.Status,
                    State = RoomOwnerDto.Status == RoomStatusEnum.Online ? "上架中" : RoomOwnerDto.Status == RoomStatusEnum.Pending ? "<i class='fas fa-hourglass-half'></i>建立中" : "已下架",
                    RoomName = RoomOwnerDto.RoomName,
                    BathroomCount = RoomOwnerDto.BathroomCount,
                    Address = $"{RoomOwnerDto.Country} {RoomOwnerDto.City}",
                    BedCount = RoomOwnerDto.BedCount,
                    RoomCount = RoomOwnerDto.RoomCount,
                    CreateTime = RoomOwnerDto.CreateTime,
                    LastChangeTime = RoomOwnerDto.LastChangeTime,
                    TypeOfLabel = RoomOwnerDto.TypeOfLabel
                });

            return View(result);
        }

        [HttpPost]
        public IActionResult HostList([FromBody]HostListSearchDto hostListSearchDto)
        {
            var result = _hostListService.SearchHostListByOwnerId(hostListSearchDto).Select(RoomOwnerDto => new HostListViewModel
            {
                RoomId = RoomOwnerDto.RoomId,
                UserId = RoomOwnerDto.UserId,
                Status = RoomOwnerDto.Status,
                State = RoomOwnerDto.Status == RoomStatusEnum.Online ? "上架中" : RoomOwnerDto.Status == RoomStatusEnum.Pending ? "<i class='fas fa-hourglass-half'></i>建立中" : "已下架",
                RoomName = RoomOwnerDto.RoomName,
                BathroomCount = RoomOwnerDto.BathroomCount,
                Address = $"{RoomOwnerDto.Country} {RoomOwnerDto.City}",
                BedCount = RoomOwnerDto.BedCount,
                RoomCount = RoomOwnerDto.RoomCount,
                CreateTime = RoomOwnerDto.CreateTime,
                LastChangeTime = RoomOwnerDto.LastChangeTime,
                TypeOfLabel = RoomOwnerDto.TypeOfLabel
            });
            return View(result);
        }

        /// <summary>
        /// 預定
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult HostReservation()
        {
            var hostid = int.Parse(User.Identity.Name);
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
        public IActionResult HostHomePageReservation()
        {
            var Hostid = int.Parse(User.Identity.Name);
            var reservation = _hostHomePageService.GetHostHomePagesReservation(Hostid).Select(homePageReservation => new HostHomePageViewModel
            {
                State = homePageReservation.State,
                RoomName = homePageReservation.RoomName,
                GuestName = homePageReservation.GuestName,
                During = $"{homePageReservation.CheckIn} - {homePageReservation.CheckOut}",
                CheckOut = homePageReservation.CheckOut
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
        [Authorize]
        public IActionResult CreateRoom()
        {

            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult CreateRoom([FromBody] CreateRoomDataModel request)
        {
            var userid = int.Parse(User.Identity.Name);

            var result = _createRoomService.CreateRoom(request, userid);

            if (!result.IsSuccess)
            {
                return new JsonResult("未加入成功");
            }

            return new JsonResult("加入房源成功");
        }


        [Authorize]
        public IActionResult Calendar()
        {
            var userid = int.Parse(User.Identity.Name);
            var result = new CalendarViewModel();
            var rooms = _calendarService.GetAllRoomByUserId(userid);
            string json1 = JsonSerializer.Serialize(rooms);
            ViewData["JsonUpDown"] = json1;
            result.UserAllRooms = rooms;

            return View(result);
        }
        [Authorize]
        public IActionResult CalendarRoomId(int roomid)
        {
            var userid = int.Parse(User.Identity.Name);
            var result = new CalendarRoomIdViewModel();
            var rooms = _calendarService.GetAllRoomByUserId(userid);
            result.UserAllRooms = rooms;
            var currentRoom = _calendarService.GetCurrentRoom(roomid);
            result.CurrentRoom = currentRoom;
            var CurrentRoomCalendar = _calendarService.GetCurrentRoomCalendar(roomid);
            result.CurrentRoomCalendar = CurrentRoomCalendar;

            string json1 = JsonSerializer.Serialize(rooms);
            ViewData["JsonUpDown"] = json1;
            string json2 = JsonSerializer.Serialize(CurrentRoomCalendar);
            ViewData["JsonCalendar"] = json2;


            return View(result);

        }
        [HttpPost]
        [Authorize]
        public IActionResult ChangeRoomStatusToDisable([FromBody] ChangeRoomStatusDataModel request)
        {

            _calendarService.ChangeStatusToHided(request);


            return new JsonResult("修改成功"); 
        }

        [HttpPost]
        [Authorize]
        public IActionResult ChangeRoomStatusToable([FromBody]ChangeRoomStatusDataModel request)
        {

            _calendarService.ChangeStatusToAble(request);

            return new JsonResult("修改成功");
        }

        [HttpPost]
        [Authorize]
        public IActionResult ChangeUnitPrice([FromBody] ChangeRoomStatusDataModel request)
        {

            _calendarService.ChangePrice(request);

            return new JsonResult("修改成功");
        }


    }
}
