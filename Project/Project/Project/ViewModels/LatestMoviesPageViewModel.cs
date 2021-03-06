﻿using GalaSoft.MvvmLight;
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
                    catch (Exception ex)
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
    }
}
