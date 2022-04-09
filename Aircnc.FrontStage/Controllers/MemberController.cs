using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Member;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        public IActionResult Upload_Identification()
        {
            return View();
        }
        [Authorize]
        public IActionResult Upload_ID_Photo()
        {
            return View();
        }
        [Authorize]
        public IActionResult Select_IdentificationType()
        {
            return View();
        }


    }
}
