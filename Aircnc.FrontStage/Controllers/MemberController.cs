using Aircnc.FrontStage.Models.DataModels.Account.Personal;
using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Member;
using AircncFrontStage.Repositories;
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
        private readonly DBRepository _dBRepository;

        public MemberController(DBRepository dBRepository)
        {
            _dBRepository = dBRepository;
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

        [HttpPost]
        [Authorize]
        public IActionResult SendUrlToDatabase([FromBody] SendUrlDataModel request)
        {
            var userid = int.Parse(User.Identity.Name);
            var select_userverification_in_user = _dBRepository.GetEntityById<User>(userid).UserVerificationId;
            var select_photoId_in_userverification = _dBRepository.GetEntityById<UserVerification>(select_userverification_in_user);

            select_photoId_in_userverification.IdPhoto = request.IdPhoto;
            _dBRepository.Update<UserVerification>(select_photoId_in_userverification);
            _dBRepository.Save();

            return RedirectToAction("PersonalBox", "Personal", new { area = "" });
        }


    [Authorize]
        public IActionResult Select_IdentificationType()
        {
            return View();
        }


    }
}
