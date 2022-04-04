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
            var room = _dbRepository.GetAll<Room>().FirstOrDefault(room => room.RoomId == roomId);
            var owner = _dbRepository.GetAll<User>().FirstOrDefault(owner => owner.UserId == room.UserId);

            var result = new RoomDetailDto() { 
                OwnerName = owner.Name,
                RoomId = room.RoomId,
                District = room.District,
                City = room.City,
                RoomName = room.RoomName,
                RoomCount = room.RoomCount,
                BedCount = room.BedCount,
                BathroomCount = room.BathroomCount,
                RoomDescription = room.RoomDescription
            };
        
            return result;
        }
    }
}
