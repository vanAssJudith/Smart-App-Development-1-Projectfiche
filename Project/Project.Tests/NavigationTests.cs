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

        [TestMethod]
        public void Navigate_MainPage_To_WishlistPage()
        {
            //Arrange
            var navigationService = SimpleIoc.Default.GetInstance<ICustomNavigation>();
            var mainPageViewModel = new MainPageViewModel(navigationService);

            //Act
            mainPageViewModel.WishlistCommand.Execute(null);

            //Assert
            Assert.AreEqual<string>(ServiceLocator.WishlistPage, navigationService.CurrentPageKey);
        }
    }
}
