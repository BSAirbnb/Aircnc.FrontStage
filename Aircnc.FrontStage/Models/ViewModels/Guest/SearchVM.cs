﻿using Aircnc.FrontStage.Models.ViewModels.Guest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.ViewModels.Guest
{
    public class SearchVM
    {
        public IEnumerable<SearchRoomViewModel> SearRoom { get; set; }
        public NavSearchVMPost NavSearch { get; set; }
    }
}
