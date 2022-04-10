using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Order;
using Aircnc.FrontStage.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;
        private static int totalRows;
        int Pages = 0;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [Authorize]
        public IActionResult OrderList(int id = 1) //透過使用者ID去找他的訂單們
        {
            //這邊先撈所有訂單資料
            int userId = int.Parse(User.Identity.Name);
            var orderList = _orderService.GetAllOrderByUserId(userId).Select(x => new OrderViewModel
            {
                CkeckIn = x.CkeckIn.ToString("yyyy/MM/dd"),
                CkeckOut = x.CkeckOut.ToString("yyyy/MM/dd"),
                RoomName = x.RoomName,
                City = x.City,
                District = x.District,
                Street = x.Street,
                RoomImg = x.RoomImg,
                RoomOwnerName = x.RoomOwnerName,
                Status = x.Status

            });

            if (totalRows == 0)
            {
                totalRows = _orderService.GetAllOrderByUserId(userId).Count();
            }

            int activePage = id; //目前所在分頁
            int pageRows = 2; //每頁幾筆資料

            //計算頁數
            if (totalRows % pageRows == 0)
            {
                Pages = totalRows / pageRows;
            }
            else
            {
                Pages = (totalRows / pageRows) + 1;
            }
            int startRow = (activePage - 1) * pageRows; //紀錄起始index
            var result = orderList.OrderBy(x => x.CkeckIn).Skip(startRow).Take(pageRows);
            
            ViewData["ActivePage"] = id; //active分頁碼
            ViewData["Pages"] = Pages; //總頁數

            return View(result);
        }

    }
}
