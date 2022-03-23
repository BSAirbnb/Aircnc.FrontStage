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
        public int TypeOfLabel { get; set; }

        public virtual Room Room { get; set; }
    }
}
