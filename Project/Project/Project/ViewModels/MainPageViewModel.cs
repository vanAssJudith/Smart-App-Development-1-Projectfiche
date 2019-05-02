using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OnBoardingOefening.Services;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IMovieAppService _appService;
        private ICustomNavigation _navigation;

        public MainPageViewModel(IMovieAppService appService, ICustomNavigation navigation)
        {
            _appService = appService;
            LoadData().GetAwaiter();
            _navigation = navigation;
        }

        public async Task LoadData()
        {
            Movies = await _appService.GetMovies();
        }

        private Movie _movies;
        public Movie Movies
        {
            get { return _movies; }
            set
            {
                _movies = value;
                RaisePropertyChanged(() => Movies);
            }
        }

        public RelayCommand SettingsPage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    _navigation.NavigateTo(ServiceLocator.LoginPage);
                });
            }
        }
    }
}
