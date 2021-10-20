//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MySql.Data.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //    .Entity<Movie>().ToTable<Movie>("Movie");
        //}
    }
}

