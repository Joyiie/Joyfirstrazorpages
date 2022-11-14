using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Joy.FirstRazorpages.Data;
using Joy.FirstRazorpages.Models;

namespace Joy.FirstRazorpages.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Joy.FirstRazorpages.Data.JoyFirstRazorpagesContext _context;

        public DetailsModel(Joy.FirstRazorpages.Data.JoyFirstRazorpagesContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
