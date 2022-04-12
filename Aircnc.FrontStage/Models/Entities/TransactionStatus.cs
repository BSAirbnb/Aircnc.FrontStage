using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [Description("還在系統中")]
        Pending = 1,

        [Description("已轉帳給房東")]
        TransferredToOwner = 2,

        [Description("已退款給旅客")]
        ReturnedToGuest = 3
    }
    // Pending = 還在系統中, TransferredToOwner = 已轉帳給房東, ReturnedToGuest = 已退款給旅客
}
