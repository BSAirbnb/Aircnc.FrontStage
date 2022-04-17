using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class CreateRoomDataModel
    {
        public int HouseType { get; set; }
        public int RoomType { get; set; }

        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Pax { get; set; }
        public int BedCount { get; set; }
        public int BathroomCount { get; set; }
        public int RoomCount { get; set; }
        public string RoomDescription { get; set; }
        public string RoomName { get; set; }
        public int UnitPrice { get; set; }
        public decimal Lat { get; set; }
        public decimal Lng{ get; set; }
        public IEnumerable<int> RoomServiceLabel { get; set; }
        public IEnumerable<string> RoomImg { get; set; }
    }
    
}
