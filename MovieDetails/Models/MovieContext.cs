using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDetails.Models
{
    public class MovieContext:DbContext
    {
        //public MovieContext()
        //{

        //}
        public MovieContext(DbContextOptions<MovieContext> options)
           : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
