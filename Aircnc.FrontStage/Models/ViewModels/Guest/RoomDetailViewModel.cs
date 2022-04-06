using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Aircnc.FrontStage.Models.Entities.RoomServiceLabel;

namespace Aircnc.FrontStage.Models.ViewModels.Guest
{
    public class RoomDetailViewModel
    {   
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhoto { get; set; }
        public DateTime OwnerCreateTime { get; set; }

        public int RoomId { get; set; }
        public HouseTypeEnum HouseType { get; set; }
        public RoomTypeEnum RoomType { get; set; }
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
        public string Status { get; set; }

        public List<RoomServiceLabel> ServiceLabels { get; set; }

        public List<ReviewsDto> Reviews { get; set; } //評價 (參考 ReviewsDto)
        [RegularExpression(@"^\d+\.\d{0,2}$")]
        public double AvgStars { get; set; } // Comment 評價平均分數
        public int ReviewsCount { get; set; } //總共幾則評價

    }
}
