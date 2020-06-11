using System;
using System.Collections.Generic;

namespace FacilityMaster.Models
{
    public partial class AccessAuthentication
    {
        public int AccessAuthId { get; set; }
        public string AccessAuthName { get; set; }
        public bool IsActive { get; set; }
    }
}
