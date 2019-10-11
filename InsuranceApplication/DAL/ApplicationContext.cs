using InsuranceApplication.Models;
using System.Data.Entity;

namespace InsuranceApplication.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("ApplicationContext")
        {
        }
        public DbSet<Insurance> Insurances { get; set; }
    }
}