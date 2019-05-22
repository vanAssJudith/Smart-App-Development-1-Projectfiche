using Flurl.Http;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        //const fields
        public const string APIKEY = "b20875c2e9b7c542349d3b7f1a42bca8";
        public const string ENDPOINT = "https://api.themoviedb.org/3/";

        public async Task<List<Movie>> GetPopularMovies()
        {
            try
            {
                var result = await $"{ENDPOINT}movie/popular?api_key={APIKEY}&language=en-US".GetJsonAsync<Result>();
                return result.Movies;
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

        public async Task<List<Movie>> GetBestRatedMovies()
        {
            try
            {
                var result = await $"{ENDPOINT}movie/top_rated?api_key={APIKEY}&language=en-US".GetJsonAsync<Result>();
                return result.Movies;
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

        public async Task<List<Movie>> GetLatestMovies()
        {
            try
            {
                var result = await $"{ENDPOINT}movie/upcoming?api_key={APIKEY}&language=en-US".GetJsonAsync<Result>();
                return result.Movies;
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

        public async Task<List<Movie>> SearchMoviesAsync(string searchTerm, int page)
        {
            try
            {
                var result = await $"{ENDPOINT}search/movie?api_key={APIKEY}&query={searchTerm}&page={page}&language=en-US".GetJsonAsync<Result>();
                return result.Movies;
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

        public async Task<List<Video>> GetVideos(string movieId)
        {
            try
            {
                VideoResult result = await $"{ENDPOINT}movie/{movieId}/videos?api_key={APIKEY}".GetJsonAsync<VideoResult>();
                List<Video> videos = result.Videos.Where(v => v.Site == "YouTube" && v.Type == "Trailer").ToList();
                return videos;

                //return result.Videos;
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

        public async Task PostRatingAsync(string movieId, Profile rating)
        {
            try
            {
                System.Net.Http.HttpResponseMessage response = await $"{ENDPOINT}/movie/{movieId}/rating".PostJsonAsync(rating);

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Kan data momenteel niet posten, probeer later opnieuw");
            }
        }

    }

}

