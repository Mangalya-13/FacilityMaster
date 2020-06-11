using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FacilityMaster;

namespace FacilityMaster.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        FacilityMaster.Repository.FacilityDetails details;
        public ValuesController(FacilityMaster.Repository.FacilityDetails faciltyDetails)
        {
            details = faciltyDetails;
        }

        // GET: api/CRS
        [HttpGet]
        public IActionResult Get()
        {
            var facilities = details.GetFacilities();
            if (facilities == null)
            {
                return NotFound();
            }

            return Ok(facilities);
        }

        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var facilities = details.GetFacilityMasters(id);
            if (facilities == null)
            {
                return NotFound();
            }

            return Ok(facilities);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] FacilityMaster.Models.Facility value)
        {
            int id = details.PostFacility(value);
            return Ok(id);
        }

        // PUT api/values/5
        [HttpPut("{value}")]
        public IActionResult Put([FromBody] FacilityMaster.Models.Facility value)
        {
            int id = details.UpdateFacility(value);
            return Ok(id);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int detail = details.DeleteFacility(id);
            return Ok(detail);
        }
    }
}
