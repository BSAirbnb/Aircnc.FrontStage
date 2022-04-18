using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Aircnc.FrontStage.Models.Entities.RoomServiceLabel;

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
            var result = _DBRepository.GetAll<Room>().Where(room => room.UserId == userid).Select(room => new HostListDto
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

        public IEnumerable<HostListDto> SearchHostListByOwnerId(HostListSearchDto hostListSearchDto)
        {
            var result = _DBRepository.GetAll<Room>().Where(room => room.UserId == hostListSearchDto.UserId).ToList();
            if (!string.IsNullOrEmpty(hostListSearchDto.KeyWord))
            {
                result = result.Where(r => r.RoomName.Contains(hostListSearchDto.KeyWord)).ToList();
            }

            if (hostListSearchDto.BedCount > 0)
            {
                result = result.Where(x => x.BedCount == hostListSearchDto.BedCount).ToList();
            }

            if (hostListSearchDto.RoomCount > 0)
            {
                result = result.Where(x => x.RoomCount == hostListSearchDto.RoomCount).ToList();

            }

            if (hostListSearchDto.BathroomCount > 0)
            {
                result = result.Where(x => x.BathroomCount == hostListSearchDto.BathroomCount).ToList();

            }

            if (hostListSearchDto.Status != null)
            {
                result = result.Where(x => (int)x.Status == hostListSearchDto.Status).ToList();
            }

            if (hostListSearchDto.TypeOfLabel?.Count > 0)
            {
                result = result.Where(r =>
                                      r.RoomServiceLabels.Where(x => (hostListSearchDto.TypeOfLabel).Contains((int)x.TypeOfLabel)).Any()
                                     ).ToList();
            }
            
            var searchResult = result.Select(x => new HostListDto
            {
                RoomId = x.RoomId,
                UserId = x.UserId,
                Status = x.Status,
                TypeOfLabel = x.RoomServiceLabels.Where(y => y.RoomId == x.RoomId).Select(y => y.TypeOfLabel).ToList(),
                RoomName = x.RoomName,
                BathroomCount = x.BathroomCount,
                Country = x.Country,
                City = x.City,
                BedCount = x.BedCount,
                RoomCount = x.RoomCount,
                CreateTime = x.CreateTime,
                LastChangeTime = x.LastChangeTime
            });

            return searchResult;
        }




    }
}
