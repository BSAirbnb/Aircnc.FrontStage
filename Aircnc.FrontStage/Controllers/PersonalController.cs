using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Member;
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
        //帳號九宮格前往個人資料的連結
        public IActionResult Personal_Details()
        {
            //假設現在房東是1
            int userid = 1;
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

        public IActionResult Personaldata(int userid) //個人資料
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
                //Birthday = target.Birthday.ToString("yyyy/MM/dd"),
                EmergencyContactName=target.EmergencyContactName,


            };
            return View(result);
        }

        public IActionResult LoginSecurity() //登入與安全
        {
            return View();
        }

        public IActionResult PaymentIndex() //付款方式頁面
        {
            return View();
        }

        public IActionResult PayoutMethod() //收款方式頁面
        {
            return View();
        }

        public IActionResult Notification() //通知
        {
            return View();
        }

        public IActionResult Privacy_and_Share() //隱私分享
        {
            return View();
        }

        public IActionResult Preference() //全域偏好設定
        {
            return View();
        }

        public IActionResult Trip() //差旅
        {
            return View();
        }

        public IActionResult RentTool() //專業出租工具
        {
            return View();
        }

        public IActionResult Invitecoupon() //邀請好友旅行基金
        {
            return View();
        }

        public IActionResult PersonalBox() //帳號首頁
        {
            return View();
        }

    }
}
