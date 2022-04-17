using Aircnc.FrontStage.Models.ViewModels.Guest;
using System.Collections.Generic;
using System.Linq;

namespace Aircnc.FrontStage.Services.Guest
{
    public class SearchControllerService
    {
        public readonly SearchRoomService _searchRoomService;
        public SearchControllerService(SearchRoomService searchRoomService)
        {
            _searchRoomService = searchRoomService;
        }
        public IEnumerable<SearchRoomViewModel> searchContorller(SearchVM searchVM)
        {
            var getRooms = _searchRoomService.GetRoom(searchVM).Select(SearchRoomDto => new SearchRoomViewModel
            {
                RoomId = SearchRoomDto.RoomId,
                UserId = SearchRoomDto.UserId,
                HouseType = SearchRoomDto.HouseType,
                RoomType = SearchRoomDto.RoomType,
                Status = SearchRoomDto.Status,
                RoomName = SearchRoomDto.RoomName,
                Pax = SearchRoomDto.Pax,
                RoomCount = SearchRoomDto.RoomCount,
                BedCount = SearchRoomDto.BedCount,
                BathroomCount = SearchRoomDto.BathroomCount,
                Country = SearchRoomDto.Country,
                City = SearchRoomDto.City,
                District = SearchRoomDto.District,
                UnitPrice = SearchRoomDto.UnitPrice,
                Lat = SearchRoomDto.Lat,
                Lng = SearchRoomDto.Lng,
                Comments = SearchRoomDto.Comments,
                Stars = SearchRoomDto.Stars,
                RoomServiceLabels = SearchRoomDto.RoomServiceLabels,
            });
            return getRooms;
        }
    }
}
