﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Services
{
    public interface IMovieAppService
    {
        Task<List<Movie>> GetBestRatedMovies();
        Task<List<Movie>> GetLatestMovies();
        Task<List<Movie>> GetPopularMovies();
        Task<List<Video>> GetVideos(string movieId);
        void ShareContent(string Title);
    }
}