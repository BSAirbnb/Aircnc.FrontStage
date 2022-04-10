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
        //public IEnumerable<SearchRoomDto> GetRoom(string location)
        public IEnumerable<SearchRoomDto> GetRoom(SearchVM input)
        {
            //var rooms = _dbRepository.GetAll<Room>().Where(room => room.City.Contains(input.NavSearch.Location) && room.Pax >= input.NavSearch.NumberOfGuests && room.Status == RoomStatusEnum.Online).Select(room => new SearchRoomDto
            var rooms = _dbRepository.GetAll<Room>().Where(room => room.City.Contains(input.NavSearch.Location) && room.Status == RoomStatusEnum.Online).Select(room => new SearchRoomDto
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
            //篩選入住人數
            if (input.NavSearch.NumberOfGuests.HasValue)
            {
                rooms = rooms.Where(room => room.Pax >= input.NavSearch.NumberOfGuests.Value).ToList();
            }
            //篩選日期與計算平均房價
            if (input.NavSearch.StartDate.HasValue)
            {
                var bookedRooms = _dbRepository.GetAll<Order>().Where(room => room.City.Contains(input.NavSearch.Location)).ToList();
                var bRsByDate = bookedRooms.Where(room => 
                                (room.CkeckOut > input.NavSearch.StartDate && room.CkeckOut <= input.NavSearch.EndDate) ||
                                (room.CkeckIn >= input.NavSearch.StartDate && room.CkeckIn < input.NavSearch.EndDate) ||
                                (room.CkeckIn <= input.NavSearch.StartDate && room.CkeckOut >= input.NavSearch.EndDate)).Select(room => room.RoomId).ToList();
                //排除日期上已被預訂的房源
                foreach (var room in rooms.ToList())
                {
                    if (bRsByDate.Contains(room.RoomId))
                    {
                        rooms.Remove(room);
                    }
                }
                //排除日期上被房東設為不出租的房源
                foreach (var room in rooms.ToList())
                {
                    var notBook = _dbRepository.GetAll<RoomCalendar>().Where(x => x.RoomId == room.RoomId && (x.Date >= input.NavSearch.StartDate && x.Date <= input.NavSearch.EndDate) && x.RoomCalendarStatus == RoomCalendarStatusEnum.Hided).Select(x => x.RoomId).ToList();
                    if (notBook.Contains(room.RoomId))
                    {
                        rooms.Remove(room);
                    }
                }
                //查RoomCalendar是否有特別設定價格並算出平均房價
                //foreach (var room in rooms.ToList())
                //{
                //    var totalBookDays = 3;
                //}
            }
            //找出評價則數,平均星等
            foreach (var room in rooms)
            {
                var comments = _dbRepository.GetAll<Comment>().Where(x => x.RoomId == room.RoomId).Select(y => y.CommentId).Count();
                var star = _dbRepository.GetAll<Comment>().Where(x => x.RoomId == room.RoomId).Select(y => y.Stars).ToList();
                var staravg = star.Count > 0 ? Math.Round(star.Average(),2) : 0;
                room.Comments = comments;
                room.Stars = staravg;
            }
            //找出房源設備
            foreach (var room in rooms)
            {
                var roomServices = _dbRepository.GetAll<RoomServiceLabel>().Where(x => x.RoomId == room.RoomId).Select(y => y.TypeOfLabel).ToList();
                room.RoomServiceLabels = roomServices;
            }
            return rooms;
        }

    }
}
