
using Aircnc.FrontStage.Models.DataModels.Account;
using Aircnc.FrontStage.Models.Dtos.Account;
using Aircnc.FrontStage.Services.Account;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Controllers
{
    public class AccountController : Controller

    {
        private readonly AccountService _accountService;
        public AccountController(AccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(SignupDataModel signupRequest)
        {
            var inputDto = new CreateAccountInputDto
            {
                Birthday = signupRequest.Birthday,
                Email = signupRequest.Email,
                Name = signupRequest.Name,
                Password = signupRequest.Password
            };

            var outputDto = _accountService.CreateAccount(inputDto);

            if(outputDto.IsSuccess)
            {
                return Redirect("/");

            }
            else
            {
                return View("Signup", inputDto);
            }
        }
    }
}
