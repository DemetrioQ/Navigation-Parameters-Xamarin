using MediaManager;
using Navigation_Parameters_Prism_Xamarin.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Navigation_Parameters_Prism_Xamarin.ViewModels
{
    public class DetailViewModel : BaseViewModel, IInitialize
    {
        public Detail Detail { get; set; }
        public bool IsPlaying { get; set; }
        public bool FirstPlay { get; set; }
        public ICommand PlayCommand { get; }
        public string PlayIcon { get => IsPlaying ? "pause" : "play"; }
        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            PlayCommand = new DelegateCommand(PlayMusic);
            FirstPlay = true;
        }

        public void Initialize(INavigationParameters parameters)
        {
            if (parameters.TryGetValue("Detail", out Detail detail))
            {
                Detail = detail;
            }
        }

        public async void PlayMusic()
        {
            if (FirstPlay)
            {
                await CrossMediaManager.Current.Play(Detail.Url);
                FirstPlay = false;
            }

            if (IsPlaying)
            {
                await CrossMediaManager.Current.Stop();
                IsPlaying = false;
            }
            else
            {
                await CrossMediaManager.Current.Play();
                IsPlaying = true;
            }

        }
    }
}
