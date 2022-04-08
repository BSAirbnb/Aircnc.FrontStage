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
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [Authorize]
        public IActionResult OrderList() //透過使用者ID去找他的訂單們
        {
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
            return View(orderList);
        }

        //public IActionResult CancelList(int userId)
        //{
        //    userId = 1;
        //    var cancelList = _orderService.GetOrderStatus().Select(x => new OrderViewModel
        //    {
        //        CkeckIn = x.CkeckIn.ToString("yyyy/MM/dd"),
        //        CkeckOut = x.CkeckOut.ToString("yyyy/MM/dd"),
        //        RoomName = x.RoomName,
        //        City = x.City,
        //        District = x.District,
        //        RoomImg = x.RoomImg,
        //        RoomOwnerName = x.RoomOwnerName,
        //        Status = x.Status

        //    });
        //    return View();
        //}
    }
}
