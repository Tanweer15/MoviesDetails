using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDetails.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public string Title { get; set; }

        public string Year { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        public int Price { get; set; }

        [Display(Name = "Rating (5 out 10 is best!)")]
        public string Rating { get; set; }
    }
}
