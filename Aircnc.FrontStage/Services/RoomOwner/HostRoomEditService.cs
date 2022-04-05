using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Aircnc.FrontStage.Models.Entities.RoomServiceLabel;

namespace Aircnc.FrontStage.Services.RoomOwner
{
    public class HostRoomEditService
    {
        private readonly DBRepository _dBRepository;

        public HostRoomEditService(DBRepository dBRepository)
        {
            _dBRepository = dBRepository;
        }

        public IEnumerable<RoomDto> GetRoomDetail(int roomId)
        {
            return _dBRepository.GetAll<Room>().Where(x => x.RoomId == roomId).Select(roomdetail => new RoomDto 
            { 
                RoomId = roomId,
                RoomName = roomdetail.RoomName,
                RoomDescription = roomdetail.RoomDescription,
                RoomGusetCount = roomdetail.Pax,
                RoomStatus = roomdetail.Status, //房源狀態
                RoomService = string.Join(",",roomdetail.RoomServiceLabels.Where(x => x.RoomId ==roomId).Select(x => x.TypeOfLabel)), //房源設備
                Country = roomdetail.Country,
                City = roomdetail.City,
                District = roomdetail.District,
                Street = roomdetail.Street,
                HouseType = roomdetail.HouseType, //房源類型
                RoomType = roomdetail.RoomType, //房間類型
                BedCount = roomdetail.BedCount, //床數
                RoomCount = roomdetail.RoomCount,  //臥室
                BathroomCount = roomdetail.BathroomCount, //衛浴
                UnitPrice = roomdetail.UnitPrice,
                RoomCheckInTime = roomdetail.RoomCheckInTime, //入住時段
                RoomCheckOutTime = roomdetail.RoomCheckOutTime  //退房時間
        });

        }
    }
}
