using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.Entities;
using Aircnc_0321.Repositories;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Aircnc.FrontStage.Services.Guest
{
    public class SearchRoom
    {
        private readonly DBRepository _DBRepository;
        public SearchRoom(DBRepository dBRepository)
        {
            _DBRepository = dBRepository;
        }

        public IEnumerable<SearchRoomResult> GetRoom(string location)
        {
            return _DBRepository.GetAll<Room>().Where(room => room.City == location).Select(room => new SearchRoomResult
            {
                RoomId = room.RoomId,
                UserId = room.UserId,
                HouseType = room.HouseType,
                RoomType = room.RoomType,
                Status = room.Status,
                RoomName = room.RoomName,
                Pax = room.Pax,
                RoomCount = room.RoomCount,
                BedCount = room.BedCount,
                BathroomCount = room.BathroomCount,
                Country = room.Country,
                City = room.City,
                District = room.District,
                UnitPrice = room.UnitPrice,

            });
        }
    }
}
