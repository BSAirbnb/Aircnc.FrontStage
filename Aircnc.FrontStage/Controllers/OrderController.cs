using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Order;
using Aircnc.FrontStage.Services;
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
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult OrderList(int UserId) //透過使用者ID去找他的訂單們
        {
            UserId = 1;
            var orderList = _orderService.GetAllOrderByUserId(UserId).Select(x => new OrderViewModel
            {
                CkeckIn = x.CkeckIn.ToString("yyyy/MM/dd"),
                CkeckOut = x.CkeckOut.ToString("yyyy/MM/dd"),
                RoomName = x.RoomName,
                City = x.City,
                District = x.District,
                Street = x.Street,
                RoomImg = x.RoomImg

            });
            return View(orderList);
        }
    }
}
