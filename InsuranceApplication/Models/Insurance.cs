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
        public List<int> PolicyType { get; set; }
        public DateTime InitialDate { get; set; }
        public int Coverage { get; set; }
        public double Price { get; set; }
        public int TypeOfRisk { get; set; }
    }
}