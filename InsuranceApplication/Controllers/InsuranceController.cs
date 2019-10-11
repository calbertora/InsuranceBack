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
        List<int> policyType = new List<int>();

        [HttpGet]
        [Route("api/insurance")]
        public IEnumerable<Insurance> GetAllProducts()
        {
            policyType.Add(1);
            Insurance[] insurances = new Insurance[]
            {
                new Insurance { Id = 1, Name = "Insurance 1", Coverage = 4, Description = "Insurance 1 Test", InitialDate = DateTime.Now, PolicyType = policyType, Price = 50, TypeOfRisk = 1},
                new Insurance { Id = 1, Name = "Insurance 2", Coverage = 4, Description = "Insurance 2 Test", InitialDate = DateTime.Now, PolicyType = policyType, Price = 50, TypeOfRisk = 1}
            };
            return insurances;
        }
    }
}
