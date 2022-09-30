using DAL;
using Entities;
using RepositoryService.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RepositoryService.Persistance.Repositories
{
    public class VideogameRepository : GenericRepository<Videogame>, IVideogameRepository
    {
        public VideogameRepository(ApplicationDbContext context) :base(context)
        {

        }

        public ICollection<Videogame> GetAllWithGenres()
        {
            return table
                .Include(x => x.Genres)
                .ToList();
        }

        public ICollection<Videogame> GetAllWithPlatformsAndGenres()
        {
            return table
                .Include(x => x.Genres)
                .Include(x => x.Platforms)
                .ToList();
        }
    }
}
