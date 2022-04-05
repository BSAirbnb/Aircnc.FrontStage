using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services
{
    public class HostListService
    {
        private readonly DBRepository _DBRepository;
        public HostListService(DBRepository DBRepository)
        {

            _DBRepository = DBRepository;
        }
        public IEnumerable<HostListDto> GetAllRoomByOwnerId(int userid)
        {
            return _DBRepository.GetAll<Room>().Where(room=>room.UserId == userid).Select(room=>new HostListDto
            {
                RoomId = room.RoomId,
                UserId = room.UserId,
                Status = room.Status,
                RoomName = room.RoomName,
                BathroomCount = room.BathroomCount,
                Country = room.Country,
                City = room.City,
                BedCount = room.BedCount,
                RoomCount = room.RoomCount,
                CreateTime = room.CreateTime,
                LastChangeTime = room.LastChangeTime
            });
        }


    }
}
