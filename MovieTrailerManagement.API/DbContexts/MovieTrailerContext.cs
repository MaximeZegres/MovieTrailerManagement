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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with data
            modelBuilder.Entity<Movie>().HasData(
                new Movie()
                {
                    Id = Guid.Parse("e249e05b-ee59-4d3e-ad1b-a56a02c28cfa"),
                    Title = "Ashby",
                    ReleaseDate = new DateTime(2015, 9, 25),
                    UrlImdb = "https://www.imdb.com/title/tt3774466/",
                    AddedDate = new DateTime(2019, 8, 2)
                },
                new Movie()
                {
                    Id = Guid.Parse("6aad4a29-118a-465f-8767-233be593bacc"),
                    Title = "Why Him",
                    ReleaseDate = new DateTime(2016, 12, 23),
                    UrlImdb = "https://www.imdb.com/title/tt4501244/",
                    AddedDate = new DateTime(2019, 8, 2)
                },
                new Movie()
                {
                    Id = Guid.Parse("b9d58f45-bf44-4d4d-8279-a6fc6c1984c4"),
                    Title = "99 Homes",
                    ReleaseDate = new DateTime(2014, 4, 27),
                    UrlImdb = "https://www.imdb.com/title/tt2891174/",
                    AddedDate = new DateTime(2019, 8, 2)
                }
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
