using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTrailerManagement.API.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public DateTimeOffset ReleaseDate {get;set;}

        public string UrlImdb { get; set; }

        public DateTimeOffset AddedDate { get; set; }



    }
}
