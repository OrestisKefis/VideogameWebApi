using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryService.Core.Repositories
{
    public interface IVideogameRepository : IGenericRepository<Videogame>
    {
        ICollection<Videogame> GetAllWithGenres();
        ICollection<Videogame> GetAllWithPlatformsAndGenres();
    }
}
