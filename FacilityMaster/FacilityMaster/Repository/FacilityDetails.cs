using FacilityMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacilityMaster.Repository
{
    public interface FacilityDetails
    {
        List<Facility> GetFacilityMasters(int id);
        List<Facility> GetFacilities();

        int PostFacility(Facility facilityDetails);
        int DeleteFacility(int id);

        int UpdateFacility(Facility facilityDetails);

    }
}
