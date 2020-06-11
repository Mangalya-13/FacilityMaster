using System;
using System.Collections.Generic;

namespace FacilityMaster.Models
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public int AssociateId { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
    }
}
