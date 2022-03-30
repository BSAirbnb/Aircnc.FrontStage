using Microsoft.AspNetCore.Mvc;

namespace Aircnc.FrontStage.Controllers.Guest
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Booking()
        {
            return View();
        }
    }
}
