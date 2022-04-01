using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.Account
{
    public class CreateAccountOutputDto
    {
        public CreateAccountOutputDto()
        {
            User = new UserData();
        }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public UserData User { get; set; }

        public class UserData
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            //public bool Gender { get; set; }

        }
    }
}
