﻿using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aircnc.FrontStage.Models.Dtos.Guest
{
    public class SearchRoomDto
    {
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public HouseTypeEnum HouseType { get; set; }
        public RoomTypeEnum RoomType { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int Pax { get; set; }
        public int BedCount { get; set; }
        public int RoomCount { get; set; }
        public int BathroomCount { get; set; }
        public string RoomDescription { get; set; }
        public string RoomName { get; set; }
        public decimal UnitPrice { get; set; }
        public RoomStatusEnum Status { get; set; }
        public Double Stars { get; set; }
        public int Comments { get; set; }
        public List<string> RoomImgs { get; set; }
        public List<int> RoomServiceLabels { get; set; }
        public List<string> WishLists { get; set; }
    }
}
