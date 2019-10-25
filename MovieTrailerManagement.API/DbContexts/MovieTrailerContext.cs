using Microsoft.EntityFrameworkCore;
using MovieTrailerManagement.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTrailerManagement.API.DbContexts
{
    public class MovieTrailerContext : DbContext
    {
        public MovieTrailerContext(DbContextOptions<MovieTrailerContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
