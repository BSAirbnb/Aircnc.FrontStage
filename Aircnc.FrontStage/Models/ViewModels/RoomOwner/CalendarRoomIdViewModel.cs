using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.ViewModels.RoomOwner
{
    public class CalendarRoomIdViewModel
    {
        public List<CalendarRoomDto> UserAllRooms { get; set; }
        public Room CurrentRoom { get; set; }

        public List<GetCurrentRoomCalendarDto> CurrentRoomCalendar { get; set; }
    }
}
