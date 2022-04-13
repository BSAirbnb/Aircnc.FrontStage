using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.ViewModels.Member
{
    public class MemberViewModel
    {
        
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string CreateTime { get; set; }
        public string Photo { get; set; }
        public bool MailIsVerify { get; set; }
    }
}
