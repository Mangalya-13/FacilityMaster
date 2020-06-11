using System;
using System.Collections.Generic;

namespace FacilityMaster.Models
{
    public partial class Worklog1
    {
        public int LogId { get; set; }
        public string TableName { get; set; }
        public int ItemId { get; set; }
        public string Action { get; set; }
        public string Comments { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
