using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Models;

namespace Herhalingsoefening.Repositories
{
    public interface ILocalDatabaseRepository
    {
        Task<IEnumerable<Movie>> GetWatchedMovies();
        Task PostMoviesAsync(Movie Movie);
    }
}