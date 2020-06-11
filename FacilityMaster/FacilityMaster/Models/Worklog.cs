using System;
using System.Collections.Generic;

namespace FacilityMaster.Models
{
    public partial class Worklog
    {
        public int LogId { get; set; }
        public int ReqDetailId { get; set; }
        public int ReqId { get; set; }
        public int StatusId { get; set; }
        public int ActionId { get; set; }
        public string Remarks { get; set; }
        public int ProcessedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
