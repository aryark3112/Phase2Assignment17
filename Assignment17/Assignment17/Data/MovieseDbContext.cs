using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment17.Models;

namespace Assignment17.Data
{
    public class MovieseDbContext : DbContext
    {
        public MovieseDbContext (DbContextOptions<MovieseDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment17.Models.Movie> Movie { get; set; } = default!;
    }
}
