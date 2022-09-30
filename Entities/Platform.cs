using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Platform
    {
        public int PlatformId { get; set; }
        public PlatformName Name { get; set; }

        //Navigation Properties
        public ICollection<Videogame> Videogames { get; set; }
        public Platform()
        {
            Videogames = new HashSet<Videogame>();
        }

        public Platform(PlatformName name)
        {
            Name = name;
            Videogames = new HashSet<Videogame>();
        }
    }
}
