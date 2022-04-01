using Aircnc.FrontStage.Common;
using Aircnc.FrontStage.Models.Dtos.Account;
using Aircnc.FrontStage.Models.Entities;
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

            if(this.IsExistAccount(input.Email))
            {
                result.Message = "此信箱已被註冊";
                return result;
            }

            var user = new User
            {
                Email = input.Email,
                Name = input.Name,
                Gender = false,
                Password = input.Password.SHA256Encrypt(),
                Birthday = input.BirthDay
            };

            _dBRepository.Create(user);
            _dBRepository.Save();

            result.IsSuccess = true;
            result.User.Id = user.UserId;

            return result;
        }

        public bool IsExistAccount(string email)
        {
            var result = _dBRepository.GetAll<User>().Any(x => x.Email == email);
            return result;
        }

        public LoginAccountOutputDto LoginAccount(LoginAccountInputDto input)
        {
            throw new NotImplementedException();
        }

        public void LogoutAccount()
        {
            throw new NotImplementedException();
        }

        public bool VertifyAccount(int userid)
        {
            throw new NotImplementedException();
        }
    }
}
