using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Herhalingsoefening.Repositories;
using Project.Models;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ViewModels
{
    public class WishlistPageViewModel : ViewModelBase
    {
        private readonly ILocalDatabaseRepository _localDatabase;
        private ICustomNavigation _navigation;

        public WishlistPageViewModel(ILocalDatabaseRepository localDatabase, ICustomNavigation navigation)
        {

            _localDatabase = localDatabase;
            LoadData().GetAwaiter();
            _navigation = navigation;
        }

        public async Task LoadData()
        {
            IEnumerable<Movie> movies = await _localDatabase.GetWishlistMovies();
            Movies = movies.ToList();
        }

        private List<Movie> _movies;
        public List<Movie> Movies
        {
            get { return _movies; }
            set
            {
                _movies = value;
                RaisePropertyChanged(() => Movies);
            }
        }

        //

        public RelayCommand<Movie> RemoveWishlist
        {
            get
            {
                return new RelayCommand<Movie>(async (movie) =>
                {

                    await _localDatabase.DeleteWishlistMovieAsync(movie);


                });
            }
        }
    }
}
