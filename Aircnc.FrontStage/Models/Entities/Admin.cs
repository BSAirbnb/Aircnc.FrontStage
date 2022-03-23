using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class Admin
    {
        public Admin()
        {
            BankVerifications = new HashSet<BankVerification>();
            TransactionStatuses = new HashSet<TransactionStatus>();
            UserVerifications = new HashSet<UserVerification>();
        }

        [Key]
        public int AdminId { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public PermissionEnum Permission { get; set; }

        public virtual ICollection<BankVerification> BankVerifications { get; set; }
        public virtual ICollection<TransactionStatus> TransactionStatuses { get; set; }
        public virtual ICollection<UserVerification> UserVerifications { get; set; }
    }
    public enum PermissionEnum
    {
        Main = 1,
        Sub = 2
    }
}
