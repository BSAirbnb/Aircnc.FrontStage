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
            var result = _DBRepository.GetAll<Room>().Where(room=>room.UserId == userid).Select(room=>new HostListDto
            {
                RoomId = room.RoomId,
                UserId = room.UserId,
                Status = room.Status,
                TypeOfLabel = room.RoomServiceLabels.Where(x => x.RoomId == room.RoomId).Select(x => x.TypeOfLabel).ToList(),
                RoomName = room.RoomName,
                BathroomCount = room.BathroomCount,
                Country = room.Country,
                City = room.City,
                BedCount = room.BedCount,
                RoomCount = room.RoomCount,
                CreateTime = room.CreateTime,
                LastChangeTime = room.LastChangeTime
            });
            return result;
        }


    }
}
