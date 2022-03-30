using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class TransactionStatus
    {

        [Key]
        public int TransactionStatusId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public DateTime CreateTime { get; set; }
        public int AdminId { get; set; }
        public decimal TotalAmount { get; set; }
        public StatusTypeEnum StatusType { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Order Order { get; set; }
        public virtual User User { get; set; }
    }

    public enum StatusTypeEnum
    {
        Pending = 1,
        TransferredToOwner = 2,
        ReturnedToGuest = 3
    }
    // Pending = 還在系統中, TransferredToOwner = 已轉帳給房東, ReturnedToGuest = 已退款給旅客
}
