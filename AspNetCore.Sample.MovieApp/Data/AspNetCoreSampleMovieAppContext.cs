using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore.Sample.MovieApp.Models
{
    public class AspNetCoreSampleMovieAppContext : DbContext
    {
        public AspNetCoreSampleMovieAppContext (DbContextOptions<AspNetCoreSampleMovieAppContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetCore.Sample.MovieApp.Models.Movie> Movie { get; set; }
    }
}
