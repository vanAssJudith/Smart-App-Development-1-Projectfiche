using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Services
{
    public interface IMovieAppService
    {
        Task<Movie> GetMovies();
    }
}