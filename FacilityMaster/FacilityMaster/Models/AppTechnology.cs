using System;
using System.Collections.Generic;

namespace FacilityMaster.Models
{
    public partial class AppTechnology
    {
        public int AppTechId { get; set; }
        public string AppTechName { get; set; }
        public bool IsActive { get; set; }
    }
}
