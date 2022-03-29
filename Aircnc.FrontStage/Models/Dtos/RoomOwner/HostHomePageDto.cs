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
        public string CkeckIn { get; set; }
        public string CkeckOut { get; set; }
    }
}
