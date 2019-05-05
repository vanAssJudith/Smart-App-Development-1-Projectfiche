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
	public partial class BestRatedMoviesPage : ContentView
	{
		public BestRatedMoviesPage ()
		{
			InitializeComponent ();
            BindingContext = App.Locator.BestRatedMoviesPageViewModel;
        }
	}
}