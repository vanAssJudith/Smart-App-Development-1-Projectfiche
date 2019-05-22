using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Herhalingsoefening.Repositories;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class PopularMoviesPageViewModel : ViewModelBase
    {

        private readonly IMovieAppService _appService;
        private ICustomNavigation _navigation;
        private readonly ILocalDatabaseRepository _localDb;

        public PopularMoviesPageViewModel(IMovieAppService appService, ICustomNavigation navigation,ILocalDatabaseRepository localDb)
        {
            _appService = appService;
            LoadData().GetAwaiter();
            _navigation = navigation;
            _localDb = localDb;
        }

        public async Task LoadData()
        {
            Movies = await _appService.GetPopularMovies();
        }

        private List<Movie> _movies;
        public List<Movie> Movies
        {
            get { return _movies; }
            set
            {
                _movies = value;
                RaisePropertyChanged(() => Movies);
            }
        }

        private Movie _selectedMovie;
        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                _selectedMovie = value;
                RaisePropertyChanged(() => SelectedMovie);
                if (_selectedMovie != null)
                {
                    try
                    {
                        NavigateToDetails();
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }


            }
        }


        public void NavigateToDetails()
        {
            if (SelectedMovie != null)
            {
                _navigation.NavigateTo(ServiceLocator.InfoPage, SelectedMovie);
            }
        }

        public RelayCommand SearchPage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    _navigation.NavigateTo(ServiceLocator.SearchPage);
                });
            }
        }

        //public RelayCommand<Movie> AddWatched
        //{
        //    get
        //    {
        //        return new RelayCommand<Movie>(async (movie) =>
        //        {
        //            await _localDb.PostWatchedMovieAsync(movie);
        //        });
        //    }
        //}

        public RelayCommand<Movie> AddWishlist
        {
            get
            {
                return new RelayCommand<Movie>(async (movie) =>
                {
                    await _localDb.PostWishlistMovieAsync(movie);
                });
            }
        }
    }
}
