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
        public async Task ShareText(string text)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = text,
                Title = "Share Text"
            });
        }

        public async Task OpenBrowser(string uri)
        {
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }

        public void SetPreference()
        {
            try
            {
                Preferences.Set("id", "1");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetPreference()
        {
            try
            {
                return Preferences.Get("id", false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
