using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using Aircnc_0321.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services
{
    public class RoomOwnerService
    {
        private readonly DBRepository _DBRepository;
        public RoomOwnerService(DBRepository DBRepository)
        {

            _DBRepository = DBRepository;
        }
        public IEnumerable<RoomOwnerDto> GetAllRoomByOwnerId(int userid)
        {
            return _DBRepository.GetAll<Room>().Where(room=>room.UserId == userid).Select(room=>new RoomOwnerDto
            {
                RoomId = room.RoomId,
                UserId = room.UserId,
                Status = room.Status,
                RoomName = room.RoomName,
                BathroomCount = room.BathroomCount,
                Address = $"{room.Country} {room.City}",
                BedCount = room.BedCount,
                RoomCount = room.RoomCount,
                CreateTime = room.CreateTime,
                LastChangeTime = room.LastChangeTime
            });
        }


    }
}
