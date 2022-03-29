using Aircnc.FrontStage.Models.Dtos.Order;
using Aircnc.FrontStage.Models.Entities;
using Aircnc_0321.Repositories;
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

        public IEnumerable<OrderDto>GetAllOrderByUserId(int UserId)
        {
            return _dbRepository.GetAll<Order>().Where(order => order.UserId == UserId).Select(order => new OrderDto
            {
                OrderId = order.OrderId,
                CkeckIn = order.CkeckIn,
                CkeckOut = order.CkeckOut,
                Address = order.Address
            });
        }

        public IEnumerable<OrderDto>GetOrderByOrderId(int OrderId)
        {
            return _dbRepository.GetAll<Order>().Where(x => x.OrderId == OrderId).Select(x=>new OrderDto
            {
                OrderId = x.OrderId,
                CkeckIn = x.CkeckIn,
                CkeckOut = x.CkeckOut,
                Address = x.Address
            });
        }
    }
}
