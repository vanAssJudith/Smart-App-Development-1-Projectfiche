using System;
using Xamarin.Forms;

namespace Project.Services
{
    public interface ICustomNavigation
    {
        string CurrentPageKey { get; }

        void Configure(string pageKey, Type pageType);
        void GoBack();
        void Initialize(NavigationPage navigation);
        void NavigateTo(string pageKey);
        void NavigateTo(string pageKey, object parameter);
    }
}