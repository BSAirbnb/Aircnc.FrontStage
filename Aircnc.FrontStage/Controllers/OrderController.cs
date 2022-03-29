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

        public IActionResult OrderList(int OrderId) //透過使用者ID去找他的訂單們
        {
            //UserId = 1;
            //var orderList = _orderService.GetAllOrderByUserId(UserId).Select(OrderDto => new OrderViewModel
            //{
            //    CkeckIn = OrderDto.CkeckIn,
            //    CkeckOut = OrderDto.CkeckOut,
            //    Address = OrderDto.Address
            //});
            //return View(orderList);

            //用訂單ID找訂單
            OrderId = 1;
            var order = _orderService.GetOrderByOrderId(OrderId).Select(x=>new OrderViewModel
            {
                CkeckIn = x.CkeckIn,
                CkeckOut = x.CkeckOut,
                Address = x.Address
            });
            return View(order);
        }
    }
}
