using Aircnc.FrontStage.Models.Dtos.Guest;
using Aircnc.FrontStage.Models.Entities;
using Aircnc.FrontStage.Models.ViewModels;
using Aircnc_0321.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services.Guest
{
    public class NavSearchService
    {
        private readonly DBRepository _dbRepository;
        public NavSearchService(DBRepository DbRepository)
        {
            _dbRepository = DbRepository;
        }

        public IEnumerable<SearchRoomDto> GetResult(NavSearchViewModel input)
        {
            var result = _dbRepository.GetAll<Room>().Where(x => x.City.Contains(input.Location)).Select(y => new SearchRoomDto() { RoomId = y.RoomId} );

            return result;
        }
    }
}
