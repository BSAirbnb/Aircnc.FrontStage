using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
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
                OwnerCreateTime = owner.CreateTime,
                OwnerReviewsCount = _dbRepository.GetAll<Comment>().Where(x => x.UserId == owner.UserId).Count(),

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

                Reviews = GetReviews(reviews),
                AvgStars = ReviewsTotalScore(reviews)
            };
        
            return result;
        }

        public double ReviewsTotalScore(List<Comment> reviews)
        {
            if (reviews.Count() != 0)
            {
                var totalScore = 0d;
                foreach (var review in reviews)
                {
                    totalScore += review.Stars;
                }
                double average = totalScore / reviews.Count();
                return average;
            }
            else
            {
                return 0;
            }
            
        }

        public List<ReviewsDto> GetReviews(List<Comment> reviews)
        {
            var result = reviews.Select(review => new ReviewsDto()
            {
                RoomId = review.RoomId,
                Reviewer = _dbRepository.GetAll<User>().FirstOrDefault(reviewer => reviewer.UserId == review.UserId),
                ReviewContent = review.CommentContent,
                ReviewTime = review.CreateTime
            }).ToList();
            return result;
        }

        public string AddToWishListService(int userId, int roomId)
        {
            bool isExisted = _dbRepository.GetAll<WishList>().Any(x => x.UserId == userId && x.RoomId == roomId);
            if (isExisted) 
            { 
                return "已經在您的願望清單內"; 
            }
            else
            {
                using (var transaction = _dbRepository._DbContext.Database.BeginTransaction())
                {
                    try
                    {
                        var wishList = new WishList()
                        {
                            UserId = userId,
                            RoomId = roomId,
                            CreateTime = DateTime.Now
                        };
                        _dbRepository.Create(wishList);
                        _dbRepository.Save();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
            bool isAdded = _dbRepository.GetAll<WishList>().Any(x => x.UserId == userId && x.RoomId == roomId);
            if (isAdded) { return "已加入到您的願望清單"; }

            return "請再試一次";
        }
    }
}
