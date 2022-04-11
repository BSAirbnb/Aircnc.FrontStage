using Aircnc.FrontStage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.ViewModels.Order
{
    public class HistoryListViewModel
    {
        public int OrderId { get; set; }
        public string RoomName { get; set; }
        public string CkeckIn { get; set; }
        public string CkeckOut { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string RoomImg { get; set; }
        public string RoomOwnerName { get; set; }
        public OrderStatusEnum Status { get; set; }

    }
}
