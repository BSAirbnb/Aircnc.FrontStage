using Aircnc.FrontStage.Models.ViewModels.Guest;
using Microsoft.AspNetCore.Mvc;

namespace Aircnc.FrontStage.Controllers.Guest
{
    public class BookingController : Controller
    {
        public IActionResult Booking()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Booking(SearchVM input)
        {
            if (TempData["roomId"] != null) { var roomId = (int)TempData["roomId"]; }
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
