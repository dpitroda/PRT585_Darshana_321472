using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminManageMovieWebApp._00Data
{
    public class MovieDBContext : DbContext
    {
     
        public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {

        }
        public DbSet<Movie>Movies { get; set; }
        
        public DbSet<Category>Categories { get; set; }

        // public DbSet<AdminManageMovieWebApp.Models.ErrorViewModel>Category_1 { get; set; }

    }
}
