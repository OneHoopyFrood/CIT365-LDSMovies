using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace LdsMvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LdsMvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<LdsMvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2003-1-1"),
                        Genre = "Religious Comedy",
                        Price = 19.99M
                    },

                    new Movie
                    {
                        Title = "Joseph Smith: Prophet of The Restoration",
                        ReleaseDate = DateTime.Parse("2005-12-31"),
                        Genre = "Religious",
                        Price = 0.00M
                    },

                    new Movie
                    {
                        Title = "The Home Teachers",
                        ReleaseDate = DateTime.Parse("2004-1-1"),
                        Genre = "Religious Comedy",
                        Price = 4.99M
                    },

                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("2003-1-3"),
                        Genre = "Religious",
                        Price = 19.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}