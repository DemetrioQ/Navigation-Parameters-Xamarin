using Navigation_Parameters_Prism_Xamarin.Models;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace Navigation_Parameters_Prism_Xamarin.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public string Title { get; set; } = "Quick Help";
        public ICommand ShowDetailCommand { get; }
        public ObservableCollection<Detail> Details { get; set; }
        public Detail Detail { get; set;}
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            Details = new ObservableCollection<Detail>() 
            { 
                new Detail(){Title = "Raining Sidewalk", Image = "RainySidewalk.jpg", Duration="5 mins"},
                new Detail(){Title = "Spring Morning", Image = "SpringMorning.jpg", Duration="7 mins"},
                new Detail(){Title = "Peace Sign", Image = "PeaceSign.jpg", Duration="4 mins"},
                new Detail(){Title = "Another Thing 2", Image = "", Duration="3 mins"}
            };
            ShowDetailCommand = new DelegateCommand<Detail>(OnMove);
        }

        public async void  OnMove(Detail detail)
        {
            Detail = detail;
            var parameters = new NavigationParameters();
            parameters.Add("Detail", Detail);
            await NavigationService.NavigateAsync($"{Config.DetailPage}", parameters);
            Detail = null;

        }
    }
}
