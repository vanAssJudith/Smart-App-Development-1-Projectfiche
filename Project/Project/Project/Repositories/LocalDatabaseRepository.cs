using Flurl.Http;
using Herhalingsoefening.Context;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        //public async Task<IEnumerable<Movie>> GetWatchedMovies()
        //{
        //    using (var db = new DatabaseContext(Path))
        //    {
        //        return await db.WatchedMovies.ToListAsync();
        //    }
        //}

        //public async Task PostWatchedMovieAsync(Movie movie)
        //{
        //    using (var db = new DatabaseContext(Path))
        //    {
        //        try
        //        {
        //            if (db.WatchedMovies.Any(m => m.Id == movie.Id))
        //                return;

        //            await db.WatchedMovies.AddAsync(movie);
        //            await db.SaveChangesAsync();

        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }

        //    }
        //}

        //public async Task DeleteWatchedMovieAsync(Movie movie)
        //{
        //    using (var db = new DatabaseContext(Path))
        //    {
        //        try
        //        {
        //            if (!db.WatchedMovies.Any(m => m.Id == movie.Id))
        //                return;

        //            db.WatchedMovies.Remove(movie);
        //            await db.SaveChangesAsync();

        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }

        //    }
        //}

        public async Task<IEnumerable<Movie>> GetWishlistMovies()
        {
            using (var db = new DatabaseContext(Path))
            {
                return await db.WishlistMovies.ToListAsync();
            }
        }

        public async Task PostWishlistMovieAsync(Movie movie)
        {
            using (var db = new DatabaseContext(Path))
            {
                try
                {
                    if (db.WishlistMovies.Any(m => m.Id == movie.Id))
                        return;

                    await db.WishlistMovies.AddAsync(movie);
                    await db.SaveChangesAsync();

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
        
        public async Task DeleteWishlistMovieAsync(Movie movie)
        {
            using (var db = new DatabaseContext(Path))
            {
                try
                {
                    if (!db.WishlistMovies.Any(m => m.Id == movie.Id))
                        return;

                    db.WishlistMovies.Remove(movie);
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
