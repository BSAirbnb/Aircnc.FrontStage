using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using Aircnc_0321.Repositories;
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
            return _dBRepository.GetAll<Order>().Where(x => x.Room.UserId == Hostid).Select(reservation => new HostHomePageDto
            {
                OwnerId = Hostid,
                Status = reservation.Status,
                GuestName = reservation.User.Name,
                RoomName = reservation.Room.RoomName,
                CkeckIn = reservation.CkeckIn.ToString("MM/dd"),
                CkeckOut = reservation.CkeckOut.ToString("MM/dd")
            }).ToList();
        }
    }
}
