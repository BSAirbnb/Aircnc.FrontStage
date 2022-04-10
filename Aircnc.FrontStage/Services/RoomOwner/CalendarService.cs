using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services.RoomOwner
{
    public class CalendarService
    {
        private readonly DBRepository _dBRepository;
        public CalendarService(DBRepository dbRepository)
        {
            _dBRepository = dbRepository;
        }


        public IQueryable<Room> GetAllRoomByUserId(int userid)
        {
            return _dBRepository.GetAll<Room>().Where(x => x.UserId == userid);
        
        }
    }
}
