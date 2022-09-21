using DataAccessLayer;
using Entities.Models;
using RepositoryServices.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Persistance.Repositories
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        public JobRepository(ApplicationContext context) : base(context)
        {

        }

    }
}
