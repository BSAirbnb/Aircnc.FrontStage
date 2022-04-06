using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels.Guest;
using AircncFrontStage.Repositories;
using System;
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
        //public IEnumerable<SearchRoomDto> GetRoom(SearchVM input, string location)
        public IEnumerable<SearchRoomDto> GetRoom(string location)
        {
            //var rooms = _dbRepository.GetAll<Room>().Where(room => room.City.Contains(input.NavSearch.Location) && room.Pax >= input.NavSearch.NumberOfGuests && room.Status == RoomStatusEnum.Online).Select(room => new SearchRoomDto
            var rooms = _dbRepository.GetAll<Room>().Where(room => room.City.Contains(location) && room.Status == RoomStatusEnum.Online).Select(room => new SearchRoomDto
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
                
            }).ToList();

            foreach (var room in rooms)
            {
                var comments = _dbRepository.GetAll<Comment>().Where(x => x.RoomId == room.RoomId).Select(y => y.CommentId).Count();
                var star = _dbRepository.GetAll<Comment>().Where(x => x.RoomId == room.RoomId).Select(y => y.Stars).ToList();
                var staravg = star.Count > 0 ? Math.Round(star.Average(),2) : 0;
                room.Comments = comments;
                room.Stars = staravg;
            }
            return rooms;
        }

    }
}
