using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class RoomCalendar
    {
        [Key]
        public int RoomCalendarId { get; set; }
        public int RoomId { get; set; }
        public DateTime Date { get; set; }
        public DateTime LastChangeTime { get; set; }
        public RoomCalendarStatusEnum RoomCalendarStatus { get; set; }
        public decimal UnitPrice { get; set; }
        public string Note { get; set; }
        public virtual Room Room { get; set; }
    }
    public enum RoomCalendarStatusEnum
    { 
        //1.被預訂 2.被房東屏蔽 3.可預訂
        Booked =1 ,
        Hided =2 ,
        Able = 3
    }

}
