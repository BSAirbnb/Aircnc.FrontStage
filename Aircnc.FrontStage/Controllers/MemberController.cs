using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Member;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class MemberController : Controller
    {
        private readonly AircncContext _db;

        public MemberController(AircncContext db)
        {
            _db = db;
        }

        public IActionResult Personal_Details(int userid)
        {
            userid = 1;
            var target = _db.Users.FirstOrDefault(user => user.UserId == userid);
            var result = new MemberViewModel
            {
                Name = target.Name,
                Address = target.Address,
                CreateTime = target.CreateTime,
                Photo = target.Photo
            };


            return View(result);
        }

        public IActionResult Preference()
        {
            return View();
        }

        public IActionResult Notification()
        {
            return View();
        }

        public IActionResult Privacy_and_Share()
        {
            return View();
        }

    }
}
