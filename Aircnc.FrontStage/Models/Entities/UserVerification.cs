using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class UserVerification
    {
        public UserVerification()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int UserVerificationId { get; set; }
        public DocumentTypeEnum DocumentType { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime ApplyTime { get; set; }
        public DateTime? CertificationTime { get; set; }
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }

    public enum DocumentTypeEnum
    {
        Identity = 1,
        Passport = 2,
        DriverLicense = 3,
    }
    //Identity身分證,Passport護照,DriverLicense駕照

    public enum StatusEnum
    {
        Verified = 1,
        NotVerified = 2,
    }
    //Verified驗證通過,NotVerified未驗證
}
