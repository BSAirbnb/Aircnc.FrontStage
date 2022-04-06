using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.Guest
{
    public class ReviewsDto
    {
        public int RoomId { get; set; }
        public User Reviewer { get; set; } //留言的 user
        public string ReviewContent { get; set; } //評價內文
        public double Stars { get; set; } 
        public DateTime ReviewTime { get; set; } //評價發出時間
    }
}
