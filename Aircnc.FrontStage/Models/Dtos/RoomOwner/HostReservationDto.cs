using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class HostReservationDto
    {
        public int RoomId { get; set; }
        public int OwnerId { get; set; }
        public string GuestName { get; set; }
        public int Status { get; set; }
        public DateTime BookingDateTime { get; set; }
        public DateTime CkeckIn { get; set; }
        public DateTime CkeckOut { get; set; }
    }
}
