using Aircnc.FrontStage.Models.ViewModels.Guest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.ViewModels.Guest
{
    public class SearchVM
    {
        public IEnumerable<SearchRoomViewModel> SearchRoom { get; set; }
        public NavSearchVMPost NavSearch { get; set; }
        public RoomDetailViewModel RoomDetailVM { get; set; }
    }
}
