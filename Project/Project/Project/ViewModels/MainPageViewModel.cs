using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Project.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ICustomNavigation navigation;

        public MainPageViewModel(ICustomNavigation navigation)
        {
            this.navigation = navigation;
        }

        //public RelayCommand WatchListCommand =>
        //new RelayCommand(() =>
        //{
        //    navigation.NavigateTo(ServiceLocator.WatchedPage);
        //});

        public RelayCommand WishlistCommand =>
        new RelayCommand(() =>
        {
            navigation.NavigateTo(ServiceLocator.WishlistPage);
        });

    }
}
