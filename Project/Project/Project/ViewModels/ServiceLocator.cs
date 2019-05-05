using GalaSoft.MvvmLight.Ioc;
using Herhalingsoefening.Repositories;
using Project.Repositories;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModels
{
    public class ServiceLocator
    {
        public const string Mainpage = "MainPage";
        public const string LoginPage = "LoginPage";
        public const string PopularMoviesPage = "PopularMoviesPage";
        public const string BestRatedMoviesPage = "BestRatedMoviesPage";
        public const string LatestMoviesPage = "LatestMoviesPage";
        public const string InfoPage = "InfoPage";
        public const string SearchPage = "SearchPage";


        public ServiceLocator()
        {
            SimpleIoc.Default.Register<IMovieRepository, MovieRepository>();
            SimpleIoc.Default.Register<ILocalDatabaseRepository, LocalDatabaseRepository>();
            SimpleIoc.Default.Register<IMovieAppService, MovieAppService>();

            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<LoginPageViewModel>();
            SimpleIoc.Default.Register<PopularMoviesPageViewModel>();
            SimpleIoc.Default.Register<BestRatedMoviesPageViewModel>();
            SimpleIoc.Default.Register<LatestMoviesPageViewModel>();
            SimpleIoc.Default.Register<InfoPageViewModel>();
            SimpleIoc.Default.Register<SearchPageViewModel>();



        }

        public MainPageViewModel MainPageViewModel
        {
            get { return SimpleIoc.Default.GetInstance<MainPageViewModel>(); }
        }
        public LoginPageViewModel LoginPageViewModel
        {
            get { return SimpleIoc.Default.GetInstance<LoginPageViewModel>(); }
        }
        public PopularMoviesPageViewModel PopularMoviesPageViewModel
        {
            get { return SimpleIoc.Default.GetInstance<PopularMoviesPageViewModel>(); }
        }
        public BestRatedMoviesPageViewModel BestRatedMoviesPageViewModel
        {
            get { return SimpleIoc.Default.GetInstance<BestRatedMoviesPageViewModel>(); }
        }
        public LatestMoviesPageViewModel LatestMoviesPageViewModel
        {
            get { return SimpleIoc.Default.GetInstance<LatestMoviesPageViewModel>(); }
        }
        public InfoPageViewModel InfoPageViewModel
        {
            get { return SimpleIoc.Default.GetInstance<InfoPageViewModel>(); }
        }
        public SearchPageViewModel SearchPageViewModel
        {
            get { return SimpleIoc.Default.GetInstance<SearchPageViewModel>(); }
        }

    }
}
