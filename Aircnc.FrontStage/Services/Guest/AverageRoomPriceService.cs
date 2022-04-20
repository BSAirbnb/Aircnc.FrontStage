using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using System;
using System.Linq;

namespace Aircnc.FrontStage.Services.Guest
{
    public class AverageRoomPriceService
    {
        private readonly DBRepository _dbRepository;
        public AverageRoomPriceService(DBRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        public decimal FindPrice(int roomid, DateTime start, DateTime end)
        {
            var totalSearchDays = DateTime.Parse(end.ToString()).Subtract(DateTime.Parse(start.ToString())).Days;
            decimal basicPrice = _dbRepository.GetAll<Room>().First(room => room.RoomId == roomid).UnitPrice;
            decimal result;
            var priceList = _dbRepository.GetAll<RoomCalendar>().Where(rc => rc.RoomId == roomid && rc.Date >= start && rc.Date < end && rc.RoomCalendarStatus == RoomCalendarStatusEnum.Able).Select(rc => rc.UnitPrice).ToList();
            if (priceList.Count != 0)
            {
                if (priceList.Count == totalSearchDays)
                {
                    result = Math.Ceiling(priceList.Average());

                    return result;
                }
                else
                {
                    for (int d = priceList.Count; d < totalSearchDays; d++)
                    {
                        priceList.Add(basicPrice);
                    }
                    result = Math.Ceiling(priceList.Average());

                    return result;
                }
            }
            else
            {
                result = basicPrice;
                return result;
            }
        }
    }
}
