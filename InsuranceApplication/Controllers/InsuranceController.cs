using InsuranceApplication.DAL;
using InsuranceApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InsuranceApplication.Controllers
{
    public class InsuranceController : ApiController
    {

        private UnitOfWork unitOfWork = new UnitOfWork();
        List<int> policyType = new List<int>();

        [HttpGet]
        [Route("api/insurance")]
        public IEnumerable<Insurance> GetAllProducts()
        {
            /*policyType.Add(1);
            Insurance[] insurances = new Insurance[]
            {
                new Insurance { Id = 1, Name = "Insurance 1", Coverage = 4, Description = "Insurance 1 Test", InitialDate = DateTime.Now, PolicyType = policyType, Price = 50, TypeOfRisk = 1},
                new Insurance { Id = 1, Name = "Insurance 2", Coverage = 4, Description = "Insurance 2 Test", InitialDate = DateTime.Now, PolicyType = policyType, Price = 50, TypeOfRisk = 1}
            };*/
            return unitOfWork.InsuranceRepository.GetAll();
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
