using System;
using System.Collections.Generic;

namespace FacilityMaster.Models
{
    public partial class Port
    {
        public int PortId { get; set; }
        public int PortNumber { get; set; }
        public string PortDescription { get; set; }
        public string Protocol { get; set; }
        public bool IsActive { get; set; }
    }
}
