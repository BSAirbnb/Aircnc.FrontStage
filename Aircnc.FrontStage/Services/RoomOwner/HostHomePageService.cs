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
            return _dBRepository.GetAll<Order>().Where(x => x.Room.UserId == Hostid).OrderBy(x => x.CkeckIn).Select(reservation => new HostHomePageDto
            {
                OwnerId = Hostid,
                Status = reservation.Status,
                //Status = StatusEnum.Future, // 這裡先暫時用future
                GuestName = reservation.User.Name,
                RoomName = reservation.Room.RoomName,
                CheckIn = reservation.CkeckIn.ToString("yyyy/MM/dd"),
                CheckOut = reservation.CkeckOut.ToString("yyyy/MM/dd"),
            }).ToList();
        }
    }
}
