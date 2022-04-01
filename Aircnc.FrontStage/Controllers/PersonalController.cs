using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Personal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class PersonalController : Controller
    {
        private readonly AircncContext _db;

        public PersonalController(AircncContext db) 
        {
            _db = db;
        
        }
        public IActionResult Personaldata(int userid)
        {
            userid = 2;
            var target = _db.Users.FirstOrDefault(user => user.UserId == userid);
            var result = new PersonalViewModel
            {
                Name=target.Name,
                Address=target.Address,
                Email=target.Email,
                Gender= (bool)target.Gender,
                Phone=target.Phone,
                Birthday = target.Birthday.ToString("yyyy/MM/dd"),
                EmergencyContactName=target.EmergencyContactName,


            };
            return View(result);
        }

        public IActionResult LoginSecurity()
        {
            return View();
        }

        public IActionResult Trip()
        {
            return View();
        }

        public IActionResult RentTool()
        {
            return View();
        }

        public IActionResult Invitecoupon()
        {
            return View();
        }

        public IActionResult PersonalBox()
        {
            return View();
        }
    }
}
