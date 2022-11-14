using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Joy.FirstRazorpages.Models;

namespace Joy.FirstRazorpages.Data
{
    public class JoyFirstRazorpagesContext : DbContext
    {
        public JoyFirstRazorpagesContext (DbContextOptions<JoyFirstRazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<Joy.FirstRazorpages.Models.Movie> Movie { get; set; } = default!;
    }
}
