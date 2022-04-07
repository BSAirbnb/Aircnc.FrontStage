using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Aircnc.FrontStage.Models.Entities.RoomServiceLabel;

namespace Aircnc.FrontStage.Services.RoomOwner
{
    public class CreateRoomService
    {
        private readonly DBRepository _repository;
       

        public CreateRoomService(DBRepository repository)
        {
            _repository = repository;
            

        }

        public CreateRoomOutputDto CreateRoom(CreateRoomDataModel request,int userid)
        {
            //mapping
            var result = new CreateRoomOutputDto
            {
                //之後要換
                IsSuccess = false,
                UserId = userid,
                CreateTime =DateTime.Now,
                Status = RoomStatusEnum.Online,
                HouseType = (HouseTypeEnum)request.HouseType,
                RoomType = (RoomTypeEnum)request.RoomType,
                Street = request.Street,
                District = request.District,
                City = request.City,
                Country = request.Country,
                Pax = request.Pax,
                BedCount = request.BedCount,
                BathroomCount = request.BedCount,
                RoomCount = request.RoomCount,
                RoomDescription = request.RoomDescription,
                RoomName = request.RoomName,
                UnitPrice = request.UnitPrice,
                Lat = request.Lat,
                Lng = request.Lng,
                //加入roomlabel
                RoomServiceLabel = request.RoomServiceLabel
                //要加入roomimg(尚未)
            };
            var room = new Room();
            using (var transaction = _repository._DbContext.Database.BeginTransaction())
            {
                try
                {
                    room = new Room
                    {

                        UserId = userid,
                        CreateTime = DateTime.Now,
                        Status = RoomStatusEnum.Online,
                        HouseType = (HouseTypeEnum)request.HouseType,
                        RoomType = (RoomTypeEnum)request.RoomType,
                        Street = request.Street,
                        District = request.District,
                        City = request.City,
                        Country = request.Country,
                        Pax = request.Pax,
                        BedCount = request.BedCount,
                        BathroomCount = request.BedCount,
                        RoomCount = request.RoomCount,
                        RoomDescription = request.RoomDescription,
                        RoomName = request.RoomName,
                        UnitPrice = request.UnitPrice,
                        Lat = request.Lat,
                        Lng = request.Lng,
                    };
                    _repository.Create(room);
                    _repository.Save();

                    //roomlabel foreach加入
                    if (result.RoomServiceLabel.Count() != 0)
                    {
                        foreach (var roomlabel in result.RoomServiceLabel)
                        {
                            RoomServiceLabel roomServiceLabel = new RoomServiceLabel
                            {
                                RoomId = room.RoomId,
                                TypeOfLabel = (TypeOfLabelEnum)roomlabel

                            };
                            _repository.Create(roomServiceLabel);


                        }
                        _repository.Save();
                        
                    }
                    //img表 foreach加入


                    transaction.Commit();
                    //_logger.LogWarning("新建房源成功!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    
                    //_logger.LogWarning(ex.ToString());
                }

            }
               
            //如果生成成功才把outputdto改成true
            if(RoomIsCreate(room))
            { 
                result.IsSuccess = true;
            }


            return result;


            


        }

        public bool RoomIsCreate(Room room)
        {
            return _repository.GetAll<Room>().Any(x => x.RoomId == room.RoomId);
        
        }



    }
}
