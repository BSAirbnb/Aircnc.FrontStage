using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Aircnc.FrontStage.Models.Entities
{
    public partial class Room
    {
        public Room()
        {
            Comments = new HashSet<Comment>();
            Orders = new HashSet<Order>();
            RoomCalendars = new HashSet<RoomCalendar>();
            RoomImgs = new HashSet<RoomImg>();
            RoomServiceLabels = new HashSet<RoomServiceLabel>();
            WishLists = new HashSet<WishList>();
        }

        [Key]
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
        public DateTime CreateTime { get; set; }
        public DateTime? LastChangeTime { get; set; }
        public string RoomCheckInTime { get; set; }
        public string RoomCheckOutTime { get; set; }
        //lat緯度
        [Required]
        [Column(TypeName = "decimal(10, 6)")]
        public decimal Lat { get; set; }
        //lng 經度
        [Required]
        [Column(TypeName = "decimal(10, 6)")]
        public decimal Lng { get; set; }
        public RoomStatusEnum Status { get; set; }
        [ StringLength(500)]
        public string Note { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RoomCalendar> RoomCalendars { get; set; }
        public virtual ICollection<RoomImg> RoomImgs { get; set; }
        public virtual ICollection<RoomServiceLabel> RoomServiceLabels { get; set; }
        public virtual ICollection<WishList> WishLists { get; set; }
    }

    public enum RoomStatusEnum
    {
        //1已上架 2已下架 3建立中 
        Online = 1,
        Offline = 2,
        Pending = 3
    }

    public enum HouseTypeEnum
    {
        //1公寓 2獨棟房屋 3獨特房源 4家庭式旅館 
        Apartment = 1 ,
        OneBuild = 2,
        Special = 3,
        Family = 4
    }
    
    public enum RoomTypeEnum
    {
        //1 整套房源 2獨立房間 3 合住房間
        FullHouse =1,
        Solo =2 ,
        Share =3
        
    }
}
