using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.Entities;
using Aircnc_0321.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services.Guest
{
    public class RoomDetailService
    {
        private readonly DBRepository _dbRepository;
        public RoomDetailService(DBRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        //以下為 RoomDetail 測試
        public RoomDetailDto GetRoomDetailById(int roomId)
        {
            var result = _dbRepository.GetAll<Room>().FirstOrDefault(x => x.RoomId == roomId);
            var room = new RoomDetailDto() { 
                RoomId = result.RoomId,
                District = result.District,
                City = result.City,
                RoomName = result.RoomName,
                RoomCount = result.RoomCount,
                BedCount = result.BedCount,
                BathroomCount = result.BathroomCount,
                RoomDescription = result.RoomDescription
            };
        
            return room;
        }
    }
}
