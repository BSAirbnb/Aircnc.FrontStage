using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class GetCurrentRoomCalendarDto
    {
        public int RoomCalendarId { get; set; }
        
        public DateTime Datetime { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Date { get; set;}
        
        public RoomCalendarStatusEnum RoomCalendarStatus { get; set; }
        public decimal UnitPrice { get; set; }
        public string Note { get; set; }
    }
}
