using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMovies.Models;

namespace MVCMovies.Models
{
    public class MVCMoviesContext : DbContext
    {
        public MVCMoviesContext (DbContextOptions<MVCMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMovies.Models.Movie> Movie { get; set; }
    }
}
