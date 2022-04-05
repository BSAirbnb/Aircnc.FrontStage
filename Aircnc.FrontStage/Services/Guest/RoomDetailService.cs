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
            var roomServiceLabel = _dbRepository.GetAll<RoomServiceLabel>().Where(label => label.RoomId == roomId).ToList();
            var reviews = _dbRepository.GetAll<Comment>().Where(room => room.RoomId == roomId).ToList();

            var result = new RoomDetailDto() {
                OwnerName = owner.Name,
                RoomId = room.RoomId,
                RoomType = room.RoomType,
                HouseType = room.HouseType,
                District = room.District,
                City = room.City,
                RoomName = room.RoomName,
                RoomCount = room.RoomCount,
                BedCount = room.BedCount,
                BathroomCount = room.BathroomCount,
                RoomDescription = room.RoomDescription,
                ServiceLabels = roomServiceLabel,
                AvgStars = ReviewsTotalScore(reviews)
                
            };
        
            return result;
        }

        public double ReviewsTotalScore(List<Comment> reviews)
        {
            var totalScore = 0d;
            foreach (var review in reviews)
            {
                totalScore += review.Stars;
            }
            double average = totalScore / reviews.Count();
            return average;
        }
    }
}
