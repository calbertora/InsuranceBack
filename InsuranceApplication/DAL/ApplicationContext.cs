using InsuranceApplication.Models;
using System.Data.Entity;

namespace InsuranceApplication.DAL
{
    public class AppContext : DbContext
    {
        public AppContext() : base("AppContext")
        {
        }
        public DbSet<Insurance> Insurances { get; set; }
    }
}