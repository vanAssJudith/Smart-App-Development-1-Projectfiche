using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Repositories
{
    public interface IMovieRepository
    {
        Task<Movie> GetMovies();
    }
}