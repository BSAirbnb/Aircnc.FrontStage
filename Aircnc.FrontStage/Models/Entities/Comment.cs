using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public string CommentContent { get; set; }
        public double Stars { get; set; }
        public DateTime CreateTime { get; set; }

        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
    }
}
