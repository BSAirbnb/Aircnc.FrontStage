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

            if (location != null) { searchVM.NavSearch.Location = location; } else { searchVM.NavSearch.Location = (string)TempData["location"]; }
            if (TempData["startDate"] != null) { searchVM.NavSearch.StartDate = DateTime.Parse(TempData["startDate"].ToString()); }
            if (TempData["endDate"] != null) { searchVM.NavSearch.EndDate = DateTime.Parse(TempData["endDate"].ToString()); }
            if (TempData["numberofGuests"] != null) { searchVM.NavSearch.NumberOfGuests = (int)TempData["numberOfGuests"]; }
            var rooms = _searchControllerService.searchContorller(searchVM);
            int activePage = id;
            int pageRows = 8; // show rows per page
            if (totalRows == 0)
            {
                totalRows = rooms.Count();
            }
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
        public IActionResult Search(int id=1)
        {
            //int userId = int.Parse(User.Identity.Name);
            SearchVM searchVM = new SearchVM() { NavSearch = new NavSearchVMPost()};

            searchVM.NavSearch.Location = (string)TempData["location"];
            if (TempData["startDate"] != null) { searchVM.NavSearch.StartDate = DateTime.Parse(TempData["startDate"].ToString()); }
            if (TempData["endDate"] != null) { searchVM.NavSearch.EndDate = DateTime.Parse(TempData["endDate"].ToString()); }
            if (TempData["numberofGuests"] != null) { searchVM.NavSearch.NumberOfGuests = (int)TempData["numberOfGuests"]; }
            var rooms = _searchControllerService.searchContorller(searchVM);
            
            int activePage = id;
            int pageRows = 8; // show rows per page
            if (totalRows == 0)
            {
                totalRows = rooms.Count();
            }
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
