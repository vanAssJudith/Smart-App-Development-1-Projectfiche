using Flurl.Http;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public async Task<Movie> GetMovies()
        {
            try
            {
                var result = await $"https://api.themoviedb.org/3/movie/popular?api_key=b20875c2e9b7c542349d3b7f1a42bca8&language=nl-NL&page=1".GetJsonAsync<Movie>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
