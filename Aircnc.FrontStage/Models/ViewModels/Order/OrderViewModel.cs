using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.ViewModels.Order
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }

        public string CkeckIn { get; set; }
        public string CkeckOut { get; set; }
        public string Address { get; set; }

    }
}
