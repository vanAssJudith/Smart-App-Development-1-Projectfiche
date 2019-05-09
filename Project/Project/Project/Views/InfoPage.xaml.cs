using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Project.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoPage : ContentPage
	{
		public InfoPage (Movie selectedMovie)
		{
			InitializeComponent ();
            App.Locator.InfoPageViewModel.SelectedMovie = selectedMovie;
            BindingContext = App.Locator.InfoPageViewModel;
        }
	}
}