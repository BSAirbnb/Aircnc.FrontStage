using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class CalendarRoomDto
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public decimal Unitprice { get; set; }
        public RoomStatusEnum Status { get; set; } 

    }
}
