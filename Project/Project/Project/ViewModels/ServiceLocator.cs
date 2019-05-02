using GalaSoft.MvvmLight.Ioc;
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

        public ServiceLocator()
        {
            SimpleIoc.Default.Register<IMovieRepository, MovieRepository>();
            SimpleIoc.Default.Register<IMovieAppService, MovieAppService>();

            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<LoginPageViewModel>();


        }

        public MainPageViewModel MainPageViewModel
        {
            get { return SimpleIoc.Default.GetInstance<MainPageViewModel>(); }
        }

        public LoginPageViewModel LoginPageViewModel
        {
            get { return SimpleIoc.Default.GetInstance<LoginPageViewModel>(); }
        }
    }
}
