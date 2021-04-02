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
        public string HeaderTitle1 { get; set; } = "Breathe";
        public string HeaderTitle2 { get; set; } = "Sleep";
        public string HeaderTitle3 { get; set; } = "Anxiety";
        public string HeaderTitle4 { get; set; } = "Stress";

        public string HeaderImage1 { get; set; } = "breath";
        public string HeaderImage2 { get; set; } = "moon";
        public string HeaderImage3 { get; set; } = "anxiety";
        public string HeaderImage4 { get; set; } = "stress";

        public string MiddleHeaderTitle { get; set; } = "Daily meditations";
        public string MiddleHeaderImage { get; set; } = "RestAndRelax.jpg";
        public string MiddleHeaderImageText1 { get; set; } = "Rest and Relax";
        public string MiddleHeaderImageBeforeText2 { get; set; } = "time";
        public string MiddleHeaderImageText2 { get; set; } = "30 mins";

        public string BottomHeaderTitle { get; set; } = "Daily meditations";
        public string BottomHeaderTitle2 { get; set; } = "ViewAll";

        public string Title { get; set; } = "Quick Help";
        public ICommand ShowDetailCommand { get; }
        public ObservableCollection<Detail> Details { get; set; }
        public Detail Detail { get; set;}
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            Details = new ObservableCollection<Detail>() 
            { 
                new Detail(){Title = "Rainy Days on the Sidewalk", Image = "RainySidewalk.jpg", Duration="5 mins", Artist="Mondo Gascaro", Url="https://audio.jukehost.co.uk/gTn7m59KmtNQJBv029vNE0ys4h8fFRKG"},
                new Detail(){Title = "A Fine Spring Morning", Image = "SpringMorning.jpg", Duration="7 mins", Artist="Blossom Dearie", Url="https://audio.jukehost.co.uk/45BykslmMQGoIBf6MAqiCbelDgn5upXP"},
                new Detail(){Title = "Peace Sign", Image = "PeaceSign.jpg", Duration="4 mins", Artist="Kenshi Yonezu", Url="https://audio.jukehost.co.uk/ZN3YrMDLYK0yKhvzVNPsevZVoHI0tEq4"}
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
