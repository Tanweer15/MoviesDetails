using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDetails.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "The Seven Samurai",
                        Year="1989",
                        ReleaseDate = DateTime.Parse("1989-01-01"),
                        Genre = "Romantic Comedy",
                        Price = 100,
                        Rating="5"
                    },
                    new Movie
                    {
                        Title = "Bonnie and Clyde",
                        Year = "1994",
                        ReleaseDate = DateTime.Parse("1994-01-01"),
                        Genre = "Comedy",
                        Price = 100,
                        Rating = "5"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        Year = "1996",
                        ReleaseDate = DateTime.Parse("1996-01-01"),
                        Genre = " Comedy",
                        Price = 120,
                        Rating = "5"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        Year = "1996",
                        ReleaseDate = DateTime.Parse("1996-01-01"),
                        Genre = "Western",
                        Price = 600,
                         Rating = "5"
                    },
                    new Movie
                    {
                        Title = "Reservoir Dogs",
                        Year = "1999",
                        ReleaseDate = DateTime.Parse("1999-01-01"),
                        Genre = "Western",
                        Price = 600,
                        Rating = "5"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
