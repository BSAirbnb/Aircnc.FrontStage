using Aircnc.FrontStage.Models.Dtos.RoomOwner;
using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services.RoomOwner
{
    public class HostReservationService
    {
        private readonly DBRepository _dBRepository;
        public HostReservationService(DBRepository dBRepository)
        {
            _dBRepository = dBRepository;
        }

        public IEnumerable<HostReservationDto> GetHostReservation(int id)
        {
            return _dBRepository.GetAll<Order>().Where(x => x.Room.UserId == id).Select(reservation => new HostReservationDto
            {
                RoomId = reservation.RoomId,
                OwnerId = id,
                GuestName = reservation.User.Name,
                Status = reservation.Status,
                BookingDateTime = reservation.BookingDateTime.ToString("yyyy/MM/dd"),
                CkeckIn = reservation.CkeckIn.ToString("yyyy/MM/dd"),
                CkeckOut = reservation.CkeckOut.ToString("yyyy/MM/dd")
            }).ToList();
        }
    }
}
