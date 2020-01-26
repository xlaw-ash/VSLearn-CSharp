using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieDB.Data;
using RazorPagesMovieDB.Models;

namespace RazorPagesMovieDB
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieDB.Data.RazorPagesMovieDBContext _context;

        public IndexModel(RazorPagesMovieDB.Data.RazorPagesMovieDBContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
