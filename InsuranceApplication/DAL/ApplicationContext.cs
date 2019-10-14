using InsuranceApplication.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace InsuranceApplication.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("InsuranceContext")
        {
        }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}