using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Member;
using Aircnc.FrontStage.Models.ViewModels.Personal;
using AircncFrontStage.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class PersonalController : Controller
    {
        private readonly DBRepository _db;

        public PersonalController(DBRepository db)
        {
            _db = db;

        }
        [Authorize]
        public IActionResult PersonalBox() //帳號首頁
        {
            var userid = int.Parse(User.Identity.Name);
            var person = _db.GetAll<User>().Where(x => x.UserId == userid).Select(x => new PersonalViewModel
            {
                Name = x.Name,
                Email = x.Email
            });
            return View(person);
        }
        //帳號九宮格前往個人資料的連結
        [Authorize] 
        public IActionResult Personal_Details()
        {
            var userid = int.Parse(User.Identity.Name);
            var target = _db.GetAll<User>().FirstOrDefault(user => user.UserId == userid);
            var result = new MemberViewModel
            {
                Name = target.Name,
                Address = target.Address,
                CreateTime = target.CreateTime,
                Photo = target.Photo
            };


            return View(result);
        }
        [Authorize]
        public IActionResult Personaldata() //個人資料
        {
            var userid = int.Parse(User.Identity.Name);
            var target = _db.GetAll<User>().FirstOrDefault(user => user.UserId == userid);
            var result = new PersonalViewModel
            {
                Name=target.Name,
                Address=target.Address,
                Email=target.Email,
                Gender= (bool)target.Gender,
                Phone=target.Phone,
                //Birthday = target.Birthday.ToString("yyyy/MM/dd"),
                EmergencyContactName=target.EmergencyContactName,


            };
            return View(result);
        }
        [Authorize]
        public IActionResult LoginSecurity() //登入與安全
        {
            return View();
        }
        [Authorize]
        public IActionResult PaymentIndex() //付款方式頁面
        {
            return View();
        }
        [Authorize]
        public IActionResult PayoutMethod() //收款方式頁面
        {
            return View();
        }
        [Authorize]
        public IActionResult Notification() //通知
        {
            return View();
        }
        [Authorize]
        public IActionResult Privacy_and_Share() //隱私分享
        {
            return View();
        }
        [Authorize]
        public IActionResult Preference() //全域偏好設定
        {
            return View();
        }
        [Authorize]
        public IActionResult Trip() //差旅
        {
            return View();
        }
        [Authorize]
        public IActionResult RentTool() //專業出租工具
        {
            return View();
        }
        [Authorize]
        public IActionResult Invitecoupon() //邀請好友旅行基金
        {
            return View();
        }
        


    }
}
