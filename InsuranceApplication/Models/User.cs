using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceApplication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Occupation { get; set; }

        public virtual ICollection<Insurance> Policies { get; set; }
    }
}