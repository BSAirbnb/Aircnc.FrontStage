using Aircnc.FrontStage.Models.Entities;
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
        public OrderStatusEnum Status { get; set; }
        public string BookingDateTime { get; set; }
        public string CkeckIn { get; set; }
        public string CkeckOut { get; set; }
    }
}
