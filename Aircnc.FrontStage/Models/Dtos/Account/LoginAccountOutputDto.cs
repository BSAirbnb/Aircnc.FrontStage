using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.Account
{
    public class LoginAccountOutputDto
    {
        public LoginAccountOutputDto()
        {
            User = new UserData();

        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public UserData User { get; set; }

        public class UserData
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }

        }
    }
}
