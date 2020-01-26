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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovieDB.Data.RazorPagesMovieDBContext _context;

        public DetailsModel(RazorPagesMovieDB.Data.RazorPagesMovieDBContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
