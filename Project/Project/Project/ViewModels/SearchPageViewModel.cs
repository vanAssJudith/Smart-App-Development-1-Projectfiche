using GalaSoft.MvvmLight;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.ViewModels
{
    public class SearchPageViewModel : ViewModelBase
    {
        private ICustomNavigation _navigation;

        public SearchPageViewModel(ICustomNavigation navigation)
        {
            _navigation = navigation;
        }
    }
}
