using System;
using System.Collections.Generic;

namespace FacilityMaster.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public bool IsActive { get; set; }
    }
}
