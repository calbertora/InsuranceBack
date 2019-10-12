using InsuranceApplication.Models;
using InsuranceApplication.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceApplication.DAL
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationContext context = new ApplicationContext();

        private Repository<Insurance> insuranceRepository;
        private Repository<User> userRepository;

        public Repository<Insurance> InsuranceRepository
        {
            get
            {
                return this.insuranceRepository ?? new Repository<Insurance>(context);
            }
        }

        public Repository<User> UserRepository
        {
            get
            {
                return this.userRepository ?? new Repository<User>(context);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false; protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}