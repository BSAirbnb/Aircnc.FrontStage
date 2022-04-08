using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.ViewModels.Guest;
using Aircnc.FrontStage.Services.Guest;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Aircnc.FrontStage.Controllers.Guest
{
    public class SearchController : Controller
    {
        private readonly SearchRoomService _searchRoomService;
        private static int totalRows; //搜尋結果總筆數
        public SearchController(SearchRoomService searchRoomService)
        {
            _searchRoomService = searchRoomService;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        public IActionResult Search(string location, int id=1)
        {
            location = (string)TempData["location"];
            if (TempData["startDate"] != null) { var startDate = DateTime.Parse(TempData["startDate"].ToString()); }
            if (TempData["endDate"] != null) { var endDate = DateTime.Parse(TempData["endDate"].ToString()); }
            if (TempData["numberofGuests"] != null) { var numberOfGuests = (int)TempData["numberOfGuests"]; }
            //location = "台北市";
            //input.NavSearch.Location = "台北";
            //input.NavSearch.NumberOfGuests = 1;
            int activePage = id;
            int pageRows = 8; // show rows per page
            if(totalRows == 0)
            {
                totalRows = _searchRoomService.GetRoom(location).Count();
            }
            int pages = 0; //計算總頁數
            if(totalRows % pageRows == 0)
            {
                pages = totalRows / pageRows;
            }
            else
            {
                pages = (totalRows / pageRows) + 1;
            }
            int startRow = (activePage - 1) * pageRows;

            var getRooms = _searchRoomService.GetRoom(location).Select(SearchRoomDto => new SearchRoomViewModel
            {
                RoomId = SearchRoomDto.RoomId,
                UserId = SearchRoomDto.UserId,
                HouseType = SearchRoomDto.HouseType,
                RoomType = SearchRoomDto.RoomType,
                Status = SearchRoomDto.Status,
                RoomName = SearchRoomDto.RoomName,
                Pax = SearchRoomDto.Pax,
                RoomCount = SearchRoomDto.RoomCount,
                BedCount = SearchRoomDto.BedCount,
                BathroomCount = SearchRoomDto.BathroomCount,
                Country = SearchRoomDto.Country,
                City = SearchRoomDto.City,
                District = SearchRoomDto.District,
                UnitPrice = SearchRoomDto.UnitPrice,
                Comments = SearchRoomDto.Comments,
                Stars = SearchRoomDto.Stars,
            });

            var result = getRooms.OrderBy(x => x.RoomId).Skip(startRow).Take(pageRows);
            var viewResult = new SearchVM { SearRoom = result };

            ViewData["ActivePage"] = id;
            ViewData["Pages"] = pages;
            ViewData["TotalRows"] = totalRows;

            TempData.Keep();

            return View(viewResult);
        }

        //public IActionResult Search()
        //{
        //    return View();
        //}
    }
}
