using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Project.Models;
using Project.Repositories;
using Project.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Project.ViewModels
{
    public class InfoPageViewModel : ViewModelBase
    {
        public IMovieRepository _movieRepository;
        private readonly IMovieAppService _appService;
        private ICustomNavigation _navigation;
        private IXamarinEssentialsRepository _xamarinEssentials;

        public InfoPageViewModel(IMovieRepository movieRepository, IMovieAppService appService, ICustomNavigation navigation, IXamarinEssentialsRepository xamarinEssentials)
        {
            _appService = appService;
            _navigation = navigation;
            _xamarinEssentials = xamarinEssentials;
            _movieRepository = movieRepository;
        }
        
        private Movie _selectedMovie;
        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                _selectedMovie = value;
                RaisePropertyChanged(() => SelectedMovie);
            }
        }

        private string _title;

        public string Title
        {
            get { return SelectedMovie.Title; }
            set {
                _title = value;
            }
        }


        public RelayCommand Share
        {
            get
            {
                return new RelayCommand(async() =>
                {
                    List<Video> videos = await _movieRepository.GetVideos(SelectedMovie.Id);
                    
                    Video video = videos.FirstOrDefault();
                    
                    if (video == null)
                        return;

                    _appService.ShareContent("https://www.youtube.com/watch?v=" + video.Key);
                });
            }
        }
        
        public RelayCommand WatchVideo
        {
            get
            {
                return new RelayCommand (async () =>
                {
                    List<Video> videos = await _movieRepository.GetVideos(SelectedMovie.Id);

                    // de eerste video uit de lijst
                    Video video = videos.FirstOrDefault();

                    //checken als video al in de lijst zit
                    if (video == null)
                        return;
                    //film openen in browers
                    await _xamarinEssentials.OpenBrowser("https://www.youtube.com/watch?v=" + video.Key);
                       
                    
                });
            }
        }

        public RelayCommand ClipboardText
        {
            get
            {
                return new RelayCommand(async () =>
                {
                    await Clipboard.SetTextAsync(Title);
                });
            }
        }
        
    }
}
