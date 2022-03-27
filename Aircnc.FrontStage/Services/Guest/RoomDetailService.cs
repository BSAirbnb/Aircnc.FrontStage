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
        public IEnumerable<RoomDetailDto> GetRoomDetailById(int roomId)
        {
            var rooms = _dbRepository.GetAll<Room>().Where(x => x.RoomId == roomId).Select(y => new RoomDetailDto()
            {
                RoomId = y.RoomId,
                District = y.District,
                City = y.City,
                RoomName = y.RoomName,
                RoomCount = y.RoomCount,
                BedCount = y.BedCount,
                BathroomCount = y.BathroomCount,
                RoomDescription = y.RoomDescription
            });

            return rooms;
        }
    }
}
