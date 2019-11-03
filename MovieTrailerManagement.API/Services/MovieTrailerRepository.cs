using MovieTrailerManagement.API.DbContexts;
using MovieTrailerManagement.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTrailerManagement.API.Services
{
    public class MovieTrailerRepository : IMovieTrailerRepository
    {
        private readonly MovieTrailerContext _context;

        public MovieTrailerRepository(MovieTrailerContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList<Movie>();
        }

        public Movie GetMovie(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _context.Movies.FirstOrDefault(m => m.Id == id);

        }
        public void AddMovie(Movie movie)
        {
            if(movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }

            movie.Id = Guid.NewGuid();

            _context.Movies.Add(movie);
        }

        public void DeleteMovie(Movie movie)
        {
            if (movie == null)
            {
                throw new ArgumentNullException(nameof(movie));
            }

            _context.Movies.Remove(movie);
        }


        public void UpdateMovie(Movie movie)
        {

        }

        public bool MovieExists(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(id));
            }

            return _context.Movies.Any(m => m.Id == id);
        }


        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
