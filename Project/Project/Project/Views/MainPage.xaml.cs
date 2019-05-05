using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project.Views
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            ////zorgt er voor dat de master page zichtbaar is
            //this.IsPresented = true;
            BindingContext = App.Locator.MainPageViewModel;

        }
    }
}
