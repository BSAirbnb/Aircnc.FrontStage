using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.Guest
{
    public class RoomDetailDto
    {
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoto { get; set; }
        public DateTime OwnerCreateTime { get; set; }

        public int RoomId { get; set; }
        public int HouseType { get; set; }
        public int RoomType { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Pax { get; set; }
        public int BedCount { get; set; }
        public int RoomCount { get; set; }
        public int BathroomCount { get; set; }
        public string RoomDescription { get; set; }
        public string RoomName { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastChangeTime { get; set; }
        public int Status { get; set; }

        public string CommentContent { get; set; }
        public double Star { get; set; }
    }
}
