using Aircnc.FrontStage.Models.Dtos.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services.Account.Interface
{
    public interface IAccountService
    {
        public CreateAccountOutputDto CreateAccount(CreateAccountInputDto input);
        public LoginAccountOutputDto LoginAccount(LoginAccountInputDto input);

        public bool IsExistAccount(string email);

        public void VerifyAccount(int userId);
        public void LogoutAccount();

    }
}
