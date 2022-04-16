using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.Order
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string RoomName { get; set; }
        public int RoomId { get; set; }
        public DateTime CkeckIn { get; set; }
        public DateTime CkeckOut { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string RoomImg { get; set; }
        public string RoomOwnerName { get; set; }
        public OrderStatusEnum Status { get; set; }




    }
}
