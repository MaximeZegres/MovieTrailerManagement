using MovieTrailerManagement.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTrailerManagement.API.Services
{
    interface IMovieTrailerRepository
    {
        IEnumerable<Movie> GetMovies();
        Movie GetMovie(Guid movieId);
        void AddMovie(Movie movie);
        void DeleteMovie(Movie movie);
        void UpdateMovie(Movie movie);
        bool MovieExists(Guid movieId);
        bool Save();
    }
}
