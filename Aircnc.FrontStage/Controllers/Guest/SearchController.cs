using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.ViewModels.Guest;
using Aircnc.FrontStage.Services.Guest;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Search(string location,int id=1)
        {
            location = "台北市";
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
            });

            var result = getRooms.OrderBy(x => x.RoomId).Skip(startRow).Take(pageRows);

            ViewData["ActivePage"] = id;
            ViewData["Pages"] = pages;
            ViewData["TotalRows"] = totalRows;

            return View(result);
        }
    }
}
