using Flurl.Http.Testing;
using GalaSoft.MvvmLight.Ioc;
using Herhalingsoefening.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Models;
using Project.Repositories;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project.Tests
{
    [TestClass]
    public class MovieRepositoryTests
    {
        [ClassInitialize]
        public static void StartUp(TestContext testContext)
        {

            //altijd nodig voor Xamarin 
            if (Application.Current != null)
                return;

            Xamarin.Forms.Mocks.MockForms.Init();
            Application.Current = new App();
        }


        [ClassCleanup]
        public static void CleanUp()
        {
            Application.Current = null;
        }

        [TestMethod]
        public void GetPopularMovies_Test()
        {
            using (var httpTest = new HttpTest())
            {
                //Arrange
                IMovieRepository repository = SimpleIoc.Default.GetInstance<IMovieRepository>();

                //Act
                var result = repository.GetPopularMovies();

                //Assert
                Assert.IsInstanceOfType(result, typeof(Task<List<Movie>>));
                httpTest.ShouldHaveCalled("https://api.themoviedb.org/3/").WithVerb(HttpMethod.Get);
            }
        }

        [TestMethod]
        public void GetLatestMovies_Test()
        {
            using (var httpTest = new HttpTest())
            {
                //Arrange
                IMovieRepository repository = SimpleIoc.Default.GetInstance<IMovieRepository>();

                //Act
                var result = repository.GetLatestMovies();

                //Assert
                Assert.IsInstanceOfType(result, typeof(Task<List<Movie>>));
                httpTest.ShouldHaveCalled("https://api.themoviedb.org/3/").WithVerb(HttpMethod.Get);
            }
        }

        [TestMethod]
        public void GetBestRatedMovies_Test()
        {
            using (var httpTest = new HttpTest())
            {
                //Arrange
                IMovieRepository repository = SimpleIoc.Default.GetInstance<IMovieRepository>();

                //Act
                var result = repository.GetBestRatedMovies();

                //Assert
                Assert.IsInstanceOfType(result, typeof(Task<List<Movie>>));
                httpTest.ShouldHaveCalled("https://api.themoviedb.org/3/").WithVerb(HttpMethod.Get);
            }
        }
        

    }
}