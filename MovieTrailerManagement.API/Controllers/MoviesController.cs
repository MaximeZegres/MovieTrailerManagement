using Microsoft.AspNetCore.Mvc;
using MovieTrailerManagement.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTrailerManagement.API.Controllers
{
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieTrailerRepository _movieTrailerRepository;

        public MoviesController(IMovieTrailerRepository movieTrailerRepository)
        {
            _movieTrailerRepository = movieTrailerRepository;
        }

        [HttpGet("api/movies")]
        public IActionResult GetMovies()
        {
            var moviesFromRepo = _movieTrailerRepository.GetMovies();
            return new JsonResult(moviesFromRepo);
        }



    }
}
