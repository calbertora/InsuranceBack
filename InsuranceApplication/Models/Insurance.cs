using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceApplication.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InitialDate { get; set; }
        public int Coverage { get; set; }
        public double Price { get; set; }
        public int TypeOfRisk { get; set; }
        public int CoveragePercentage { get; set; }
        
        public virtual ICollection<PolicyTypes> PolicyTypes { get; set; }
    }

    public class PolicyTypes
    {
        public int ID { get; set; }
        public string Descriptio { get; set; }
    }
}