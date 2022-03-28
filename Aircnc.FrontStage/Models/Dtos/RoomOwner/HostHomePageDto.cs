using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class HostHomePageDto
    {
        public int OwnerId { get; set; }
        public int Status { get; set; }
        public string RoomName { get; set; }
        public string GuestName { get; set; }
        public DateTime CkeckIn { get; set; }
        public DateTime CkeckOut { get; set; }
    }
}
