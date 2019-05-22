using GalaSoft.MvvmLight.Ioc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Project.Services;
using Project.ViewModels;
using Xamarin.Forms;

namespace Project.Tests
{
    [TestClass]
    public class NavigationTests
    {
        [ClassInitialize]
        public static void StartUp(TestContext testContext)
        {
            if (Application.Current != null)
                return;

            //altijd nodig voor Xamarin 
            Xamarin.Forms.Mocks.MockForms.Init();
            Application.Current = new App();
        }


        [ClassCleanup]
        public static void CleanUp()
        {
            Application.Current = null;
        }

        //[TestMethod]
        //public void Navigate_PopularMoviesPage_To_SearchPage()
        //{
        //    //Arrange
        //    var navigationService = SimpleIoc.Default.GetInstance<ICustomNavigation>();
        //    var firstPageViewModel = new PopularMoviesPageViewModel(navigationService);

        //    //Act
        //    firstPageViewModel.SearchPage.Execute(null);

        //    //Assert
        //    Assert.AreEqual<string>(ServiceLocator.SearchPage, navigationService.CurrentPageKey);
        //}
    //}
    }
}
