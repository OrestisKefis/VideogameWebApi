using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class VideogameViewModel
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
        public List<string> Genres { get; set; }
        public List<string> Platforms { get; set; }

        public VideogameViewModel()
        {
            Genres = new List<string>();
            Platforms = new List<string>();
        }
    }
}
