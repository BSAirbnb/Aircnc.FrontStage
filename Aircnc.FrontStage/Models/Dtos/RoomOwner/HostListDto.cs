﻿using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.Dtos.RoomOwner
{
    public class HostListDto
    {
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public string RoomName { get; set; }
        public int BathroomCount { get; set; }
        public string Address { get; set; }
        public int Status { get; set; }
        public int BedCount { get; set; }
        public int RoomCount { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastChangeTime { get; set; }
    }
}
