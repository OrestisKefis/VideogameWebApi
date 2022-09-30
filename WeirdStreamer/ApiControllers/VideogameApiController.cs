using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DAL;
using Entities;
using Entities.ViewModels;
using RepositoryService.Persistance;
using System.Web.Http.Results;

namespace WeirdStreamer.ApiControllers
{
    public class VideogameApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private UnitOfWork unit;

        public VideogameApiController()
        {
            unit = new UnitOfWork(db);
        }

        // GET: api/VideogameApi
        public IEnumerable<VideogameViewModel> GetVideoGames()
        {
            var videogames = unit.Videogames.GetAllWithPlatformsAndGenres();
            return VideogamesToViewModel(videogames);
        }

        private static IEnumerable<VideogameViewModel> VideogamesToViewModel(ICollection<Videogame> videogames)
        {
            List<VideogameViewModel> models = new List<VideogameViewModel>();
            List<string> genreTypes;
            List<string> platformNames;

            foreach (var videogame in videogames)
            {
                genreTypes = new List<string>();
                platformNames = new List<string>();

                foreach (var genre in videogame.Genres)
                {
                    genreTypes.Add(genre.Type.ToString());
                }

                foreach (var platform in videogame.Platforms)
                {
                    platformNames.Add(platform.Name.ToString());
                }

                models.Add(new VideogameViewModel
                {
                    VideogameId = videogame.VideogameId,
                    Title = videogame.Title,
                    PhotoUrl = videogame.PhotoUrl,
                    Rating = videogame.Rating,
                    UserRating = videogame.UserRating,
                    TrailerUrl = videogame.TrailerUrl,
                    Price = videogame.Price,
                    PegiAgeRating = videogame.PegiAgeRating,
                    DateReleased = videogame.DateReleased,
                    Genres = genreTypes,
                    Platforms = platformNames
                });
            }

            return models;
        }

        private static IEnumerable<object> VideogamesToViewModelAlt(ICollection<Videogame> videogames)
        {
            var yolo = videogames.Select(x => new
            {
                Titlos = x.Title,
                Eidh = x.Genres.Select(y => new
                {
                    Tupos = y.Type.ToString()
                }),

            });

            return yolo;
        }

        // GET: api/VideogameApi/5
        [ResponseType(typeof(Videogame))]
        public IHttpActionResult GetVideogame(int id)
        {
            Videogame videogame = unit.Videogames.GetById(id);
            if (videogame == null)
            {
                return NotFound();
            }

            return Ok(videogame);
        }

        // PUT: api/VideogameApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVideogame(int id, Videogame videogame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != videogame.VideogameId)
            {
                return BadRequest();
            }

            unit.Videogames.Update(videogame);

            try
            {
                unit.Complete();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VideogameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/VideogameApi
        [ResponseType(typeof(Videogame))]
        public IHttpActionResult PostVideogame(Videogame videogame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            unit.Videogames.Insert(videogame);
            unit.Complete();

            return CreatedAtRoute("DefaultApi", new { id = videogame.VideogameId }, videogame);
        }

        // DELETE: api/VideogameApi/5
        [ResponseType(typeof(Videogame))]
        public IHttpActionResult DeleteVideogame(int id)
        {
            Videogame videogame = unit.Videogames.GetById(id);
            if (videogame == null)
            {
                return NotFound();
            }

            unit.Videogames.Delete(videogame);
            unit.Complete();

            return Ok(videogame);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                unit.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VideogameExists(int id)
        {
            return db.VideoGames.Count(e => e.VideogameId == id) > 0;
        }
    }
}