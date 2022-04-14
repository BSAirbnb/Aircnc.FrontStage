using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.Transaction
{
    public class TransactionDto
    {
        public int TransactionStatusId { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public DateTime CreateTime { get; set; }
        public int AdminId { get; set; }
        public decimal TotalAmount { get; set; }
        public StatusTypeEnum StatusType { get; set; }
        public string RoomName { get; set; }
    }
}
