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
        public IActionResult Index1(int userid)
        {
            userid = 2;
            var target = _db.Users.FirstOrDefault(user => user.UserId == userid);
            var result = new PersonalViewModel
            {
                Name=target.Name,
                Address=target.Address,
                Email=target.Email,
                Gender=target.Gender,
                Phone=target.Phone,
                Birthday = target.Birthday.ToString("yyyy/MM/dd"),
                EmergencyContactName=target.EmergencyContactName,


            };
            return View(result);
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Index7()
        {
            return View();
        }

        public IActionResult Index8()
        {
            return View();
        }

        public IActionResult Index9()
        {
            return View();
        }

        public IActionResult Index99()
        {
            return View();
        }
    }
}
