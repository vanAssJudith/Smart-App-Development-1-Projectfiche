using Project.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Project.Repositories
{
    public class XamarinEssentialsRepository : IXamarinEssentialsRepository
    {
        public async Task ShareUrl(string url)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = url,
                Title = "Share Text"
            });
        }

        public async Task OpenBrowser(string uri)
        {
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
    }
}
