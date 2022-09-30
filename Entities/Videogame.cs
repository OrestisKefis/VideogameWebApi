using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Videogame
    {
        public int VideogameId { get; set; }
        public string Title { get; set; }
        public string PhotoUrl { get; set; }
        public double? Rating { get; set; }
        public double? UserRating { get; set; }
        public string TrailerUrl { get; set; }
        public double Price { get; set; }
        public PegiAgeRating PegiAgeRating { get; set; }
        public DateTime DateReleased { get; set; }


        //Navigation Properties
        public ICollection<Genre> Genres { get; set; }
        public ICollection<Platform> Platforms { get; set; }

        public Videogame()
        {
            Genres = new HashSet<Genre>();
            Platforms = new HashSet<Platform>();
        }

        public Videogame(string title, string photoUrl, double rating, double userRating, string trailerUrl, double price, PegiAgeRating pegiAgeRating, DateTime dateReleased)
        {
            Title = title;
            PhotoUrl = photoUrl;
            Rating = rating;
            UserRating = userRating;
            TrailerUrl = trailerUrl;
            Price = price;
            PegiAgeRating = pegiAgeRating;
            DateReleased = dateReleased;
            Genres = new HashSet<Genre>();
            Platforms = new HashSet<Platform>();
        }
    }
}
