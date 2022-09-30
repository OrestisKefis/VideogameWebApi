using DAL;
using Entities;
using Enums;
using RepositoryService.Persistance;
using RepositoryService.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments
{
    class Program
    {
        static void Main(string[] args)
        {
            //ApplicationDbContext db = new ApplicationDbContext();
            //UnitOfWork unit = new UnitOfWork(db);

            //var videogames = unit.Videogames.GetAllWithGenres();

            //List<VideogameViewModel> models = new List<VideogameViewModel>();

            //foreach (var videogame in videogames)
            //{
            //    models.Add(new VideogameViewModel
            //    {
            //        VideogameId = videogame.VideogameId,
            //        Title = videogame.Title,
            //        PhotoUrl = videogame.PhotoUrl,
            //        Rating = videogame.Rating,
            //        UserRating = videogame.UserRating,
            //        TrailerUrl = videogame.TrailerUrl,
            //        Price = videogame.Price,
            //        PegiAgeRating = videogame.PegiAgeRating,
            //        DateReleased = videogame.DateReleased,
            //        Genres = videogame.Genres
            //    });
            //}

            //foreach (var game in models)
            //{
            //    Console.WriteLine($"{game.Title}");
            //    foreach (var genre in game.Genres)
            //    {
            //        Console.WriteLine(genre);
            //    }
            //}
        }
    }
}
