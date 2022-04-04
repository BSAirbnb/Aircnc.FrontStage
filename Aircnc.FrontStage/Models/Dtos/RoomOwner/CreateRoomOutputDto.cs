using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class CreateRoomOutputDto
    {
        public int UserId { get; set; }
        public DateTime CreateTime { get; set; }
        public RoomStatusEnum Status { get; set; }

        public HouseTypeEnum HouseType { get; set; }
        public RoomTypeEnum RoomType { get; set; }

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
        public decimal Lng { get; set; }
    }
}
