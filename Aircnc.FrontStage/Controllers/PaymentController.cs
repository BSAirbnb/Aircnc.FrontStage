using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult PaymentIndex() //付款方式頁面
        {
            return View();
        }

        public IActionResult PayoutMethod() //收款方式頁面
        {
            return View();
        }
    }
}
