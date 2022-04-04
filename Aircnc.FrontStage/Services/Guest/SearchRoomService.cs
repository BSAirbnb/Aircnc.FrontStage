using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.Entities;
using Aircnc_0321.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Aircnc.FrontStage.Services.Guest
{
    public class SearchRoomService
    {
        private readonly DBRepository _dbRepository;
        public SearchRoomService(DBRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
        public IEnumerable<SearchRoomDto> GetRoom(string location)
        {
            var rooms = _dbRepository.GetAll<Room>().Where(room => room.City == location && room.Status == RoomStatusEnum.Online).Select(room => new SearchRoomDto
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
                Comments = room.Comments.Count,
            });

            //foreach (var room in rooms)
            //{
            //    var comments = _dbRepository.GetAll<Comment>().Where(x => x.RoomId == room.RoomId).Select(y => y.CommentId).Count();
            //    var start = _dbRepository.GetAll<Comment>().Where(x => x.RoomId == room.RoomId).Select(y => y.Stars).Average();
            //    room.Comments = comments;
            //    room.Stars = start;
            //}
            return rooms;
        }

    }
}
