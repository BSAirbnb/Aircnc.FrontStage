﻿using Aircnc.FrontStage.Common;
using Aircnc.FrontStage.Models.Dtos.Account;
using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Services.Account.Interface;
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

        public AccountService(DBRepository dBRepository)
        {
            _dBRepository = dBRepository;
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
                //Gender應改成可為null 改完後把這邊刪掉
                Gender = false,
                Password = input.Password.SHA256Encrypt(),
                //user entity要加一個email是否已經驗證
                //加email是否已經驗證 = false
                Birthday = input.Birthday

            };
            _dBRepository.Create(user);
            _dBRepository.Save();
            //mail驗證信發出去
            //_mailService.SendVerifyMail(user.Email, user.Id);

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
            throw new NotImplementedException();
        }
    }
}
