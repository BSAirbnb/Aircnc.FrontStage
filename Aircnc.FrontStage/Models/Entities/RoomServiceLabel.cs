using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            [Description("WiFi")]
            Wifi =1 ,
            [Description("廚房")]
            Kitchen =2,
            [Description("電視 TV")]
            TV = 3,
            [Description("洗衣機")]
            Washing = 4,
            [Description("空調")]
            Aircon = 5,
            [Description("停車位")]
            Parking =6
        }
    }
}
