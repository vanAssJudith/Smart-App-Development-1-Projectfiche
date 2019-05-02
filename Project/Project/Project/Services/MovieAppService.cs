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
        }

        public async Task<Movie> GetMovies()
        {
            return await _movieRepository.GetMovies();

        }
    }
}
