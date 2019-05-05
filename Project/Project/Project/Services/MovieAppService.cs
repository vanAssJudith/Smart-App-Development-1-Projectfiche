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
        private readonly IMovieRepository _movieRepository;
        public MovieAppService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
            //_localDatabaseRepository = localDatabaseRepository;
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
        
    }
}
