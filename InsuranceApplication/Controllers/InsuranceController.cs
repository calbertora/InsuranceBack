using InsuranceApplication.DAL;
using InsuranceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace InsuranceApplication.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")] 
    public class InsuranceController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();


        [HttpGet]
        [Route("api/insurance")]
        public IEnumerable<Insurance> GetAll()
        {
            return unitOfWork.InsuranceRepository.GetAll();
        }

        [HttpGet]
        [Route("api/insurance/{id}")]
        public Insurance Get(int id)
        {
            return unitOfWork.InsuranceRepository.Get(id);
        }

        [HttpPost]
        [Route("api/insurance")]
        public IHttpActionResult Post(Insurance insurance)
        {
                     
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.InsuranceRepository.Add(insurance);
                    return Ok("The Insurance was added");
                }
                else
                {
                    return BadRequest("Couldn't save");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("api/insurance/{id}")]
        public void Delete(int id)
        {
            unitOfWork.InsuranceRepository.Delete(id);
        }

        [HttpPut]
        [Route("api/insurance")]
        public IHttpActionResult Put([FromBody] Insurance insurance)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.InsuranceRepository.Update(insurance);
                    return Ok("The Insurance has been updated");
                }
                else
                {
                    return BadRequest("Couldn't update");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
