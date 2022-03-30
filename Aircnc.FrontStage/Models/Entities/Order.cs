using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class Order
    {
        public Order()
        {
            TransactionStatuses = new HashSet<TransactionStatus>();
        }

        [Key]
        public int OrderId { get; set; }
        public DateTime BookingDateTime { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public DateTime CkeckIn { get; set; }
        public DateTime CkeckOut { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public OrderStatusEnum Status { get; set; }
        public decimal? Discount { get; set; }
        public int BedCount { get; set; }
        public int RoomCount { get; set; }
        public int GuestCount { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        //public string Address { get; set; }
        public string Street { get; set; }

        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TransactionStatus> TransactionStatuses { get; set; }
    }
    public enum PaymentTypeEnum
    {
        CreditCard = 1,  LinePay= 2
    }
    public enum OrderStatusEnum
    {
        Past = 1 , Cancel = 2 , Future = 3
    }
}
