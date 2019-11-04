using Microsoft.AspNetCore.Mvc;
using MovieTrailerManagement.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTrailerManagement.API.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieTrailerRepository _movieTrailerRepository;

        public MoviesController(IMovieTrailerRepository movieTrailerRepository)
        {
            _movieTrailerRepository = movieTrailerRepository;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            var moviesFromRepo = _movieTrailerRepository.GetMovies();
            return Ok(moviesFromRepo);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovie(Guid id)
        {
            var moviefromRepo = _movieTrailerRepository.GetMovie(id);

            if (moviefromRepo == null)
            {
                return NotFound();
            }
            
            return Ok(moviefromRepo);
        }





    }
}
