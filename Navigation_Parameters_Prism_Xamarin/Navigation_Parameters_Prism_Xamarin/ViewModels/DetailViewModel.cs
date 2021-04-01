using Navigation_Parameters_Prism_Xamarin.Models;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation_Parameters_Prism_Xamarin.ViewModels
{
    public class DetailViewModel : BaseViewModel, IInitialize
    {
        public Detail Detail { get; set; }
        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        public void Initialize(INavigationParameters parameters)
        {
            if (parameters.TryGetValue("Detail", out Detail detail))
            {
                Detail = detail;
            }
        }
    }
}
