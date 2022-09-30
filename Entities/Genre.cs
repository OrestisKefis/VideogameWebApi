using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Genre
    {
        public int GenreId { get; set; }
        public GenreType Type { get; set; }


        //Navigation Properties
        public ICollection<Videogame> Videogames { get; set; }


        public Genre()
        {
            Videogames = new HashSet<Videogame>();
        }

        public Genre(GenreType type)
        {
            Type = type;
            Videogames = new HashSet<Videogame>();
        }
    }
}
