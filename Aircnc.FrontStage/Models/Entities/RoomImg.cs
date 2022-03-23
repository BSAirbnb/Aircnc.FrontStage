using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class RoomImg
    {
        [Key]
        public int RoomImgId { get; set; }
        public int RoomId { get; set; }
        public string ImageUrl { get; set; }
        public int Sort { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual Room Room { get; set; }
    }
}
