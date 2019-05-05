using GalaSoft.MvvmLight;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class LatestMoviesPageViewModel : ViewModelBase
    {
        private readonly IMovieAppService _appService;
        private ICustomNavigation _navigation;

        public LatestMoviesPageViewModel(IMovieAppService appService, ICustomNavigation navigation)
        {
            _appService = appService;
            LoadData().GetAwaiter();
            _navigation = navigation;
        }

        public async Task LoadData()
        {
            Movies = await _appService.GetLatestMovies();
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
    }
}
