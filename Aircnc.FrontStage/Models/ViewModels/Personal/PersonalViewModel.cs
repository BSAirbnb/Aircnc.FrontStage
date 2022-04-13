using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aircnc.FrontStage.Models.ViewModels.Personal
{
    public class PersonalViewModel
    {
        public string Name { get; set; }
        public string Address{ get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        
        public string Birthday { get; set; }

        public string EmergencyContactName { get; set; }
    }
}
