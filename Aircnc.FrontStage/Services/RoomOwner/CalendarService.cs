using Aircnc.FrontStage.Models.DataModels.RoomOwner;
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
                RoomId=x.RoomId,
                RoomCalendarId = x.RoomCalendarId,
                Datetime = x.Date,
                Date = x.Date.ToString("d"),
                Note = x.Note ?? "",
                UnitPrice = x.UnitPrice,
                RoomCalendarStatus = (int)x.RoomCalendarStatus
            }
            ).ToList();
        }

        public void ChangeStatusToHided(ChangeRoomStatusDataModel request)
        {
            //如果已經有資料 要變更
            if (isDataExist(request))
            {
                var target = _dBRepository.GetAll<RoomCalendar>().FirstOrDefault(x => x.Date == request.Date.ToLocalTime() && x.RoomId == request.RoomId);
                target.RoomCalendarStatus = RoomCalendarStatusEnum.Hided;
                target.LastChangeTime = DateTime.Now;
                _dBRepository.Update<RoomCalendar>(target);
                
            }
            else //沒有資料 創新的
            {
                var target = new RoomCalendar() {

                    RoomId = request.RoomId,
                    Date = request.Date.ToLocalTime(),
                     LastChangeTime = DateTime.Now,
                     RoomCalendarStatus = RoomCalendarStatusEnum.Hided,
                     UnitPrice = request.UnitPrice

                };
                _dBRepository.Create<RoomCalendar>(target);
                
            }
            _dBRepository.Save();
        }
        public void ChangeStatusToAble(ChangeRoomStatusDataModel request)
        {
            //如果已經有資料 要變更
            if (isDataExist(request))
            {
                var target = _dBRepository.GetAll<RoomCalendar>().FirstOrDefault(x => x.Date == request.Date.ToLocalTime() && x.RoomId == request.RoomId);
                target.RoomCalendarStatus = RoomCalendarStatusEnum.Able;
                target.LastChangeTime = DateTime.Now;
                _dBRepository.Update<RoomCalendar>(target);
                
            }
            else //沒有資料 創新的
            {
                var target = new RoomCalendar()
                {

                    RoomId = request.RoomId,
                    Date = request.Date.ToLocalTime(),
                    LastChangeTime = DateTime.Now,
                    RoomCalendarStatus = RoomCalendarStatusEnum.Able,
                    UnitPrice = request.UnitPrice

                };
                _dBRepository.Create<RoomCalendar>(target);

            }
            _dBRepository.Save();

        }

        //改價格
        public void ChangePrice(ChangeRoomStatusDataModel request)
        {
            //如果已經有資料 要變更
            if (isDataExist(request))
            {
                var target = _dBRepository.GetAll<RoomCalendar>().FirstOrDefault(x => x.Date == request.Date.ToLocalTime() && x.RoomId == request.RoomId);
                target.UnitPrice = request.UnitPrice;
                target.LastChangeTime = DateTime.Now;
                _dBRepository.Update<RoomCalendar>(target);

            }
            else //沒有資料 創新的
            {
                var target = new RoomCalendar()
                {

                    RoomId = request.RoomId,
                    Date = request.Date.ToLocalTime(),
                    LastChangeTime = DateTime.Now,
                    RoomCalendarStatus = RoomCalendarStatusEnum.Able,
                    UnitPrice = request.UnitPrice

                };
                _dBRepository.Create<RoomCalendar>(target);

            }
            _dBRepository.Save();

        }

        public bool isDataExist(ChangeRoomStatusDataModel request)
        {
            var isExist = _dBRepository.GetAll<RoomCalendar>().Any(x => x.RoomId == request.RoomId && x.Date == request.Date.ToLocalTime());
                return isExist;
        }

    }
}
