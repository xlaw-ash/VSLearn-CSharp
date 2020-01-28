using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovieDB.Data;

namespace RazorPagesMovieDB.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieDBContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieDBContext>>()))
            {
                // Check if database contains any Movie
                if (context.Movie.Any())
                {
                    return; //Database has been seeded
                }

                // Add Movies to empty database (Seeding)
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Alita: Battle Angel",
                        ReleaseDate = DateTime.Parse("Feb-14-2019"),
                        Genre = "Sci-Fi, Action, Adventure",
                        Rating = 7.3F,
                        RunTime = DateTime.Parse("2:2")
                    },
                    new Movie
                    {
                        Title = "Captain Marvel",
                        ReleaseDate = DateTime.Parse("Mar-08-2019"),
                        Genre = "Sci-Fi, Action, Adventure",
                        Rating = 6.9F,
                        RunTime = DateTime.Parse("2:3")
                    },
                    new Movie
                    {
                        Title = "Spider-Man: Into the Spider-Verse",
                        ReleaseDate = DateTime.Parse("Dec-14-2018"),
                        Genre = "Animation, Action, Adventure",
                        Rating = 8.4F,
                        RunTime = DateTime.Parse("1:57")
                    },
                    new Movie
                    {
                        Title = "The Dark Knight",
                        ReleaseDate = DateTime.Parse("July-18-2008"),
                        Genre = "Action, Crime, Drama",
                        Rating = 9F,
                        RunTime = DateTime.Parse("2:32")
                    },
                    new Movie
                    {
                        Title = "Greta",
                        ReleaseDate = DateTime.Parse("Mar-1-2019"),
                        Genre = "Drama, Mystery, Thriller",
                        Rating = 6F,
                        RunTime = DateTime.Parse("1:38")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
