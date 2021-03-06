using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.ViewModels.Guest;
using Aircnc.FrontStage.Services.Guest;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Aircnc.FrontStage.Controllers.Guest
{
    public class SearchController : Controller
    {
        private readonly SearchControllerService _searchControllerService;
        private static int totalRows; //搜尋結果總筆數
        public SearchController(SearchRoomService searchRoomService, SearchControllerService searchControllerService)
        {
            _searchControllerService = searchControllerService;
        }
        [HttpGet]
        public IActionResult Search(string location, int id = 1)
        {
            SearchVM searchVM = new SearchVM() { NavSearch = new NavSearchVMPost() };

            if (location != null) 
            { 
                searchVM.NavSearch.Location = location;
                TempData["location"] = location;
            } 
            else 
            { 
                searchVM.NavSearch.Location = (string)TempData["location"]; 
            }
            if (TempData["startDate"] != null) { searchVM.NavSearch.StartDate = DateTime.Parse(TempData["startDate"].ToString()); }
            if (TempData["endDate"] != null) { searchVM.NavSearch.EndDate = DateTime.Parse(TempData["endDate"].ToString()); }
            if (TempData["numberofGuests"] != null) { searchVM.NavSearch.NumberOfGuests = (int)TempData["numberOfGuests"]; }
            var rooms = _searchControllerService.searchContorller(searchVM);
            //取經緯度往view傳
            var locations = rooms.Select(room => new { room.lat, room.lng }).ToArray();
            string jsonLocations = JsonConvert.SerializeObject(locations);
            ViewData["Locations"] = jsonLocations;

            //分頁
            int activePage = id;
            int pageRows = 8; // show rows per page
            totalRows = rooms.Count();

            int pages = 0; //計算總頁數
            if (totalRows % pageRows == 0)
            {
                pages = totalRows / pageRows;
            }
            else
            {
                pages = (totalRows / pageRows) + 1;
            }
            int startRow = (activePage - 1) * pageRows;
            var result = rooms.OrderBy(x => x.RoomId).Skip(startRow).Take(pageRows);
            searchVM.SearchRoom = result;

            ViewData["ActivePage"] = id;
            ViewData["Pages"] = pages;
            ViewData["TotalRows"] = totalRows;

            TempData.Keep();

            return View(searchVM);
        }

        [HttpPost]
        public IActionResult Search([FromBody] SearchVM searchVM)
        //public IActionResult Search([FromBody] string input)
        {
            var id = 1;
            //SearchVM searchVM = new SearchVM();
            //SearchVM searchVM = System.Text.Json.JsonSerializer.Deserialize<SearchVM>(input);
            //int userId = int.Parse(User.Identity.Name);

            //searchVM.NavSearch.Location = (string)TempData["location"];
            //if (TempData["startDate"] != null) { searchVM.NavSearch.StartDate = DateTime.Parse(TempData["startDate"].ToString()); }
            //if (TempData["endDate"] != null) { searchVM.NavSearch.EndDate = DateTime.Parse(TempData["endDate"].ToString()); }
            //if (TempData["numberofGuests"] != null) { searchVM.NavSearch.NumberOfGuests = (int)TempData["numberOfGuests"]; }
            var rooms = _searchControllerService.searchContorller(searchVM);
            
            int activePage = id;
            int pageRows = 8; // show rows per page
            totalRows = rooms.Count();
            
            int pages = 0; //計算總頁數
            if (totalRows % pageRows == 0)
            {
                pages = totalRows / pageRows;
            }
            else
            {
                pages = (totalRows / pageRows) + 1;
            }
            int startRow = (activePage - 1) * pageRows;
            var result = rooms.OrderBy(x => x.RoomId).Skip(startRow).Take(pageRows);
            searchVM.SearchRoom = result ;

            ViewData["ActivePage"] = id;
            ViewData["Pages"] = pages;
            ViewData["TotalRows"] = totalRows;

            TempData.Keep();

            return View(searchVM);
        }

        
    }
}
