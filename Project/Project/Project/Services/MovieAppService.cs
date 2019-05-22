using Herhalingsoefening.Repositories;
using Project.Models;
using Project.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Services
{
    public class MovieAppService : IMovieAppService
    {
        private readonly IXamarinEssentialsRepository _shareRepository;
        private readonly IMovieRepository _movieRepository;
        private readonly ILocalDatabaseRepository _localDatabaseRepository;
        public MovieAppService(IMovieRepository movieRepository, IXamarinEssentialsRepository shareRepository, ILocalDatabaseRepository localDatabaseRepository)
        {
            _movieRepository = movieRepository;
            _localDatabaseRepository = localDatabaseRepository;
            _shareRepository = shareRepository;
        }

        public async Task<List<Movie>> GetPopularMovies()
        {
            return await _movieRepository.GetPopularMovies();
        }

        public async Task<List<Movie>> GetBestRatedMovies()
        {
            return await _movieRepository.GetBestRatedMovies();
        }

        public async Task<List<Movie>> GetLatestMovies()
        {
            return await _movieRepository.GetLatestMovies();
        }
        
        public void ShareContent(string url)
        {
            _shareRepository.ShareUrl(url);
        }

        public async Task<List<Video>> GetVideos(string movieId)
        {
            return await _movieRepository.GetVideos(movieId);
        }

    }
}
