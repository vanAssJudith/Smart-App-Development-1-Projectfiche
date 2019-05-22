using Flurl.Http;
using Herhalingsoefening.Context;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingsoefening.Repositories
{
    public class LocalDatabaseRepository : ILocalDatabaseRepository
    {
        private readonly string Path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "movies.db");
        
        public LocalDatabaseRepository()
        {
            Setup();
        }
        
        private void Setup()
        {
            try
            {
                using (var db = new DatabaseContext(Path))
                {
                    db.Database.EnsureCreated();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<Movie>> GetWatchedMovies()
        {
            using (var db = new DatabaseContext(Path))
            {
                return await db.Movies.ToListAsync();
            }
        }


        public async Task PostMoviesAsync(Movie Movie)
        {
            using (var db = new DatabaseContext(Path))
            {
                try
                {
                    await db.Movies.AddAsync(Movie);
                    await db.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
    }
}
