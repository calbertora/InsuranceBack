using InsuranceApplication.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace InsuranceApplication.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("ApplicationContext")
        {
        }
        public DbSet<Insurance> Insurances { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}