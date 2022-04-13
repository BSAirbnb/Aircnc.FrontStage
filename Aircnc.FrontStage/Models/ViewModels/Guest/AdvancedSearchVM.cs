using Aircnc.FrontStage.Models.Entities;
using System.Collections.Generic;
using static Aircnc.FrontStage.Models.Entities.RoomServiceLabel;

namespace Aircnc.FrontStage.Models.ViewModels.Guest
{
    public class AdvancedSearchVM
    {
        public int minPrice { get; set; }
        public int maxPrice { get; set; }
        public List<HouseTypeEnum> houseTypes { get; set; }
        public List<RoomTypeEnum> roomTypes { get; set; }
        public int bedCount { get; set; }
        public int roomCount { get; set; }
        public int bathroomCount { get; set; }
        public List<TypeOfLabelEnum> roomServiceLabels { get; set; }


    }
}
