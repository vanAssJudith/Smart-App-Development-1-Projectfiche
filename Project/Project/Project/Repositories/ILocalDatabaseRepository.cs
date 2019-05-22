using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Models;

namespace Herhalingsoefening.Repositories
{
    public interface ILocalDatabaseRepository
    {
        //Task<IEnumerable<Movie>> GetWatchedMovies();
        Task<IEnumerable<Movie>> GetWishlistMovies();
        //Task PostWatchedMovieAsync(Movie Movie);
        Task PostWishlistMovieAsync(Movie Movie);
        //Task DeleteWatchedMovieAsync(Movie movie);
        Task DeleteWishlistMovieAsync(Movie movie);
    }
}