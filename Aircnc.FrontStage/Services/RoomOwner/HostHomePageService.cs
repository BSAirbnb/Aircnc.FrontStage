using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services.RoomOwner
{
    public class HostHomePageService
    {
        private readonly DBRepository _dBRepository;
        public HostHomePageService(DBRepository dBRepository)
        {
            _dBRepository = dBRepository;
        }

        public IEnumerable<HostHomePageDto> GetHostHomePagesReservation(int Hostid)
        {
            var result = _dBRepository.GetAll<Order>().Where(x => x.Room.UserId == Hostid).OrderBy(x => x.CkeckIn).Select(reservation => new HostHomePageDto
            {
                OwnerId = Hostid,
                Status = reservation.Status,
                State = HostHomePageState(reservation),
                //Status = StatusEnum.Future, // 這裡先暫時用future
                GuestName = reservation.User.Name,
                RoomName = reservation.Room.RoomName,
                CheckIn = reservation.CkeckIn.ToString("yyyy/MM/dd"),
                CheckOut = reservation.CkeckOut.ToString("yyyy/MM/dd"),
            }).ToList();
            return result;
        }

        private static string HostHomePageState(Order data)
        {
            var now = DateTime.Now;
            if (new TimeSpan(data.CkeckIn.Ticks - now.Ticks).Days > 0 || (new TimeSpan(data.CkeckIn.Ticks - now.Ticks).Hours < 24 && new TimeSpan(data.CkeckIn.Ticks - now.Ticks).Hours >= 0))
            {
                return "即將入住";
            }
            if (new TimeSpan(now.Ticks - data.CkeckIn.Ticks).Days == 0 && new TimeSpan(data.CkeckOut.Ticks - now.Ticks).Hours > 0)
            {
                return "目前接待中";
            }
            if (new TimeSpan(data.CkeckOut.Ticks - now.Ticks).Days > 0 && new TimeSpan(data.CkeckOut.Ticks - now.Ticks).Days < 1)
            {
                return "即將退房";
            }
            return "已退房";
        }
    }
}
