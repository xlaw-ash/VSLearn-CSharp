using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieDB.Models;

namespace RazorPagesMovieDB.Data
{
    public class RazorPagesMovieDBContext : DbContext
    {
        public RazorPagesMovieDBContext (DbContextOptions<RazorPagesMovieDBContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieDB.Models.Movie> Movie { get; set; }
    }
}
