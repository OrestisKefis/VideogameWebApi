using DAL;
using RepositoryService.Core;
using RepositoryService.Core.Repositories;
using RepositoryService.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryService.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        public IVideogameRepository Videogames { get; private set; }

        private readonly ApplicationDbContext context;
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            context = dbContext;
            Videogames = new VideogameRepository(context);
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public void Complete()
        {
            context.SaveChanges();
        }
    }
}
