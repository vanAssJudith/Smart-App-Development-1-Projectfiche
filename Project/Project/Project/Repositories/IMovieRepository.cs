using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Repositories
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetBestRatedMovies();
        Task<List<Movie>> GetPopularMovies();
        Task<List<Movie>> GetLatestMovies();
        Task<List<Video>> GetVideos(string movieId);
    }
}