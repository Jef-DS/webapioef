using RESTapioef001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTapioef001.Controllers
{
    public class PlantenController : ApiController
    {
        public IEnumerable<Plant> GetPlanten()
        {
            using (deschopEntities db = new deschopEntities())
            {
                return (from p in db.PLANTEN
                       select new Plant { Art_Code = p.ART_CODE, Plantennaam = p.PLANTENNAAM }).ToList();
            }
        }
        public IHttpActionResult GetPlant(String id)
        {
            using (deschopEntities db = new deschopEntities())
            {
                PLANTEN plant = db.PLANTEN.FirstOrDefault(p => p.ART_CODE == id);
                if (plant != null)
                {
                    return Ok(plant);
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
