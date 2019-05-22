using Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Herhalingsoefening.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Movie> WatchedMovies { get; set; }
        public DbSet<Movie> WishlistMovies { get; set; }
        private string _databasePath;

        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite($"Filename={_databasePath}");
        }

    }
}
