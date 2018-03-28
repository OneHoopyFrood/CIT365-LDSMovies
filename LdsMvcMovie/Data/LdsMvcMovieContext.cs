using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LdsMvcMovie.Models
{
    public class LdsMvcMovieContext : DbContext
    {
        public LdsMvcMovieContext (DbContextOptions<LdsMvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<LdsMvcMovie.Models.Movie> Movie { get; set; }
    }
}
