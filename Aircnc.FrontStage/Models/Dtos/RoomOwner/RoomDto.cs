using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Aircnc.FrontStage.Models.Entities.RoomServiceLabel;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class RoomDto
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public string RoomDescription { get; set; }
        public int RoomGusetCount { get; set; }
        public RoomStatusEnum RoomStatus { get; set; } //房源狀態
        public string RoomService { get; set; } //房源設備
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public HouseTypeEnum HouseType { get; set; } //房源類型
        public RoomTypeEnum RoomType { get; set; } //房間類型
        public int RoomServiceLabelId { get; set; }
        public int BedCount { get; set; } //床數
        public int RoomCount { get; set; } //臥室
        public int BathroomCount { get; set; } //衛浴
        public decimal UnitPrice { get; set; }
        public string RoomCheckInTime { get; set; } //入住時段
        public string RoomCheckOutTime { get; set; } //退房時間
    }
}
