using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.ViewModels.Order
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        public DateTime CkeckIn { get; set; }
        public DateTime CkeckOut { get; set; }
        public string Address { get; set; }

    }
}
