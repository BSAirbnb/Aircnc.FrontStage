using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class HostHomePageDto
    {
        public int OwnerId { get; set; }
        public OrderStatusEnum Status { get; set; }
        public string State { get; set; }

        public string RoomName { get; set; }
        public string GuestName { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }


    }
}
