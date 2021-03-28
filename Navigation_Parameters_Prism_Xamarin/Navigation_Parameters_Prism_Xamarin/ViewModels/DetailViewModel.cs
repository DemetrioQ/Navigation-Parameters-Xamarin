using Navigation_Parameters_Prism_Xamarin.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation_Parameters_Prism_Xamarin.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        public Detail Detail { get; set; }
        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            if (parameters.GetNavigationMode() == NavigationMode.Back)
            {
                if (parameters.TryGetValue("Detail", out Detail detail))
                {
                    Detail = detail;
                }

            }
        }
    }
}
