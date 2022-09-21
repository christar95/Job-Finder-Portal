using DataAccessLayer;
using RepositoryServices.Core;
using RepositoryServices.Core.Repositories;
using RepositoryServices.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext db;
        public ICompanyRepository Companies { get; private set; }

        public IJobRepository Jobs { get; private set; }

        public IJobSeekerRepository JobSeeker { get; private set; }
        public UnitOfWork(ApplicationContext context)
        {
            db = context;
            Companies = new CompanyRepository(context);
            Jobs = new JobRepository(context);
            JobSeeker = new JobSeekerRepository(context);
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
