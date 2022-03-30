using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class BankVerification
    {
        public BankVerification()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public int BankVerificationId { get; set; }
        public StatusEnum Status { get; set; }
        [Required]
        public string BankAccount { get; set; }
        public DateTime ApplyTime { get; set; }
        public DateTime CertificationTime { get; set; }
        public int AdminId { get; set; }
        public string BankbookImg { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }

    public enum StatusEnum
    {
        Verified = 1,
        NotVerified = 2
    }
}
// Verified = 已驗證, NotVerified = 未驗證