using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult OrderList()
        {
            return View();
        }
    }
}
