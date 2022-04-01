using Aircnc.FrontStage.Common;
using Aircnc.FrontStage.Models.Dtos.Account;
using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Services.Account.Interface;
using Aircnc.FrontStage.Services.Common;
using AircncFrontStage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly DBRepository _dBRepository;
        private readonly MailService _mailService;

        public AccountService(DBRepository dBRepository, MailService mailService)
        {
            _dBRepository = dBRepository;
            _mailService = mailService;
        }

        public CreateAccountOutputDto CreateAccount(CreateAccountInputDto input)
        {
            var result = new CreateAccountOutputDto();
            result.IsSuccess = false;
            result.User.Name = input.Name;
            result.User.Email = input.Email;
            //判斷資料庫中是否有這個email
            if (IsExistAccount(input.Email))
            {
                result.Message = "該Email已經被註冊";
                return result;
            }


            //做成entity
            var user = new User
            {
                Email = input.Email,
                Name = input.Name,
                Gender = false,
                Password = input.Password.SHA256Encrypt(),
                CreateTime = DateTime.Now,
                MailIsVerify=false,
                Phone = "0912444444",
                IsDelete =false,
                

                //Birthday = DateTime.Now

            };
            _dBRepository.Create(user);
            _dBRepository.Save();
            //mail驗證信發出去
            _mailService.SendVerifyMail(user.Email, user.UserId);

            result.IsSuccess = true;
            result.User.UserId = user.UserId;
            return result;

        }

        public bool IsExistAccount(string email)
        {
            return _dBRepository.GetAll<User>().Any(user=>user.Email == email);
        }

        public LoginAccountOutputDto LoginAccount(LoginAccountInputDto input)
        {
            throw new NotImplementedException();
        }

        public void LogoutAccount()
        {
            throw new NotImplementedException();
        }

        public void VerifyAccount(int userId)
        {
            var user = _dBRepository.GetAll<User>().First(x => x.UserId == userId);

            if (!user.MailIsVerify)
            {
                user.MailIsVerify = true;
                _dBRepository.Update<User>(user);
                _dBRepository.Save();
            }
        }
    }
}
