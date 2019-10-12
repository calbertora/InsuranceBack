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
    public class UserController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        [HttpGet]
        [Route("api/user")]
        public IEnumerable<User> GetAll()
        {
            return unitOfWork.UserRepository.GetAll();
        }

        [HttpGet]
        [Route("api/user/{id}")]
        public User Get(int id)
        {
            return unitOfWork.UserRepository.Get(id);
        }

        [HttpPost]
        [Route("api/user")]
        public IHttpActionResult Post(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.UserRepository.Add(user);
                    return Ok("The user was added");
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

        [HttpPut]
        [Route("api/insurance")]
        public IHttpActionResult Put([FromBody] User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.UserRepository.Update(user);
                    return Ok("The User has been updated");
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
