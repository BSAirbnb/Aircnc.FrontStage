using Aircnc.FrontStage.Models.Dtos.RoomOwner;
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


        public List<CalendarRoomDto> GetAllRoomByUserId(int userid)
        {
            return _dBRepository.GetAll<Room>().Where(x => x.UserId == userid).Select
                (x=>new CalendarRoomDto { RoomId = x.RoomId,RoomName = x.RoomName,Status =x.Status,Unitprice = x.UnitPrice}).ToList();
        
        }
        public Room GetCurrentRoom(int roomid)
        {
            return _dBRepository.GetEntityById<Room>(roomid);

        }
        public List<GetCurrentRoomCalendarDto> GetCurrentRoomCalendar(int roomid)
        {
            return _dBRepository.GetAll<RoomCalendar>().Where(x=>x.RoomId == roomid).Select(x => new GetCurrentRoomCalendarDto
            {
                RoomCalendarId = x.RoomCalendarId,
                Datetime = x.Date,
                Date = x.Date.ToString("d"),
                Note = x.Note ?? "",
                UnitPrice = x.UnitPrice,
                RoomCalendarStatus = (int)x.RoomCalendarStatus
            }
            ).ToList();
        }
    }
}
