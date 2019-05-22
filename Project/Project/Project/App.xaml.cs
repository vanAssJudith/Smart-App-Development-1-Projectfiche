using GalaSoft.MvvmLight.Ioc;
using Project.Services;
using Project.ViewModels;
using Project.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Project
{
    public partial class App : Application
    {
        private static ServiceLocator _locator;
        public static ServiceLocator Locator
        {
            get
            {
                return _locator ?? (_locator = new ServiceLocator());
            }

        }

        public App()
        {
            InitializeComponent();

            // Setup Nav service
            var nav = new NavigationService();
            nav.Configure(ServiceLocator.Mainpage, typeof(MainPage));
            nav.Configure(ServiceLocator.PopularMoviesPage, typeof(PopularMoviesPage));
            nav.Configure(ServiceLocator.BestRatedMoviesPage, typeof(BestRatedMoviesPage));
            nav.Configure(ServiceLocator.LatestMoviesPage, typeof(LatestMoviesPage));
            nav.Configure(ServiceLocator.InfoPage, typeof(InfoPage));
            nav.Configure(ServiceLocator.SearchPage, typeof(SearchPage));
            nav.Configure(ServiceLocator.WatchedPage, typeof(WatchedPage));
            nav.Configure(ServiceLocator.WishlistPage, typeof(WishlistPage));

            SimpleIoc.Default.Register<ICustomNavigation>(() => nav);

            var mainPage = new NavigationPage(new MainPage());
            nav.Initialize(mainPage);
            MainPage = mainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
