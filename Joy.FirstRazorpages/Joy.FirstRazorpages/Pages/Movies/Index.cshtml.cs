using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Joy.FirstRazorpages.Data;
using Joy.FirstRazorpages.Models;

namespace Joy.FirstRazorpages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Joy.FirstRazorpages.Data.JoyFirstRazorpagesContext _context;

        public IndexModel(Joy.FirstRazorpages.Data.JoyFirstRazorpagesContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        public SelectList? Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
