using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacilityMaster.Models;
using Microsoft.EntityFrameworkCore;
using FacilityMaster.Repository;

namespace FacilityMaster.Repository
{
    public class FacilityManagement : FacilityDetails
    {
        FacilityMaster.Models.CrsContext db;
        public FacilityManagement(FacilityMaster.Models.CrsContext context)
        {
            db = context;
        }
        public List<Facility> GetFacilityMasters(int Id)
        {
            if (db != null)
            {
                return db.Facility.Where(x => x.FacilityId == Id).ToList();
            }
            return null;
        }

        public int DeleteFacility(int id)
        {
            if (db != null)
            {
                Facility details = db.Facility.Find(id);
                db.Facility.Remove(details);
                db.SaveChanges();
            }
            return 0;
        }

        public List<Facility> GetFacilities()
        {
            if (db != null)
            {
                return db.Facility.ToList();
            }
            return null;
        }

        public int PostFacility(Facility facilityDetails)
        {
            if (db != null)
            {
                db.Facility.Add(facilityDetails);
                db.SaveChanges();
                return facilityDetails.FacilityId;
            }
            return 0;
        }

        public int UpdateFacility(Facility facilityDetails)
        {
            if (db != null)
            {
                db.Facility.Update(facilityDetails);
                db.SaveChanges();
                return facilityDetails.FacilityId;
            }
            return 0;
        }
    }
}
