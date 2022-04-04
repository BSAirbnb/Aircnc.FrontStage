using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.ViewModels.Guest
{
    public class NavSearchVMPost
    {
        [StringLength(50)]
        public string Location { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? NumberOfGuests { get; set; }
    }
}
