using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDetails.Models
{
    public class MovieYearViewModel
    {

        public List<Movie> Movies { get; set; }
        public SelectList Year { get; set; }
        public string MovieYear { get; set; }
        public string SearchString { get; set; }
    }
}
