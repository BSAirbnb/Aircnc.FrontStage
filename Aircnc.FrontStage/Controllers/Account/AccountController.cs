using Aircnc.FrontStage.Models.DataModels.Account;
using Aircnc.FrontStage.Models.Dtos.Account;
using Aircnc.FrontStage.Services.Account.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers.Account
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(SignupDataModel request)
        {
            var inputDto = new CreateAccountInputDto
            {
                Email = request.Email,
                Name = request.Name,
                Birthday = request.Birthday,
                Password = request.Password
            };
            var outputDto = _accountService.CreateAccount(inputDto);
            if (outputDto.IsSuccess)
            {
                //先跳回首頁看以後要怎樣
                return  RedirectToAction("/");
            }
            else 
            {
                return View("Signup", inputDto);
            }

            
        }
    }
}
