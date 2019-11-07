using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTrailerManagement.API.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public DateTimeOffset ReleaseDate {get;set;}

        public string UrlImdb { get; set; }

        public DateTimeOffset AddedDate { get; set; }



    }
}
