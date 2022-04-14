using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.DataModels.RoomOwner
{
    public class ChangeRoomStatusDataModel
    {
       
        public int RoomId { get; set; }
        public DateTime Date { get; set; }
        public int UnitPrice { get; set; }
        public int RoomCalendarStatus { get; set; }
        
        
        
    }
}
