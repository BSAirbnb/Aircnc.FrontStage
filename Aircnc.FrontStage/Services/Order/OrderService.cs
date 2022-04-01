using Aircnc.FrontStage.Models.Dtos.Order;
using Aircnc.FrontStage.Models.Entities;
using AircncFrontStage.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Services
{
    public class OrderService
    {
        public readonly DBRepository _dbRepository;
        public OrderService(DBRepository dBRepository)
        {
            _dbRepository = dBRepository;
        }

        public IEnumerable<OrderDto>GetAllOrderByUserId(int userId) //撈使用者所有的訂單(包含過去現在取消)
        {
            return _dbRepository.GetAll<Order>().Where(order => order.UserId == userId).Select(order => new OrderDto
            {
                OrderId = order.OrderId,
                RoomName = order.RoomName,
                CkeckIn = order.CkeckIn,
                CkeckOut = order.CkeckOut,
                Country = order.Country,
                City = order.City,
                District = order.District,
                Street = order.Street,
                RoomImg = _dbRepository.GetAll<RoomImg>()
                .Where(x => x.RoomId == order.RoomId).OrderBy(x => x.Sort).Select(x=>x.ImageUrl).FirstOrDefault(),
                RoomOwnerName = (_dbRepository.GetAll<User>().FirstOrDefault(x => x.UserId == order.Room.UserId)).Name
            }) ;
        }

    }
}
