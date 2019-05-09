using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModels
{
    public class InfoPageViewModel : ViewModelBase
    {
        private readonly IMovieAppService _appService;
        private ICustomNavigation _navigation;

        public InfoPageViewModel(IMovieAppService movieService, ICustomNavigation navigationService)
        {

            this._appService = movieService;
            this._navigation = navigationService;
        }

        //properties
        private Movie _selectedMovie;
        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set { _selectedMovie = value; RaisePropertyChanged(() => SelectedMovie); }
        }

        private string _title;

        public string Title
        {
            get { return SelectedMovie.Title; }
            set {
                _title = value;
            }
        }


        public RelayCommand Share
        {
            get
            {
                return new RelayCommand(() =>
                {
                    _appService.ShareContent(Title);
                });
            }
        }
    }
}
