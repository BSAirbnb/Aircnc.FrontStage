using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class RoomServiceLabel
    {
        [Key]
        public int RoomServiceLabelId { get; set; }
        public int RoomId { get; set; }
        public TypeOfLabelEnum TypeOfLabel { get; set; }

        public virtual Room Room { get; set; }

        public enum TypeOfLabelEnum
        { 
            Wifi =1 ,
            Kitchen=2,
            TV = 3,
            Washing = 4,
            Aircon = 5,
            Parking =6
        }
    }
}
