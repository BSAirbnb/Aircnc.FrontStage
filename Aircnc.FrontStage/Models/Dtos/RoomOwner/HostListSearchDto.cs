using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Aircnc.FrontStage.Models.Entities.RoomServiceLabel;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class HostListSearchDto
    {
        public int? UserId { get; set; }
        public int? BathroomCount { get; set; }
        public int? BedCount { get; set; }
        public int? RoomCount { get; set; }
        public int? Status { get; set; }
        public List<int> TypeOfLabel { get; set; }
        public string KeyWord { get; set; }
    }
}
