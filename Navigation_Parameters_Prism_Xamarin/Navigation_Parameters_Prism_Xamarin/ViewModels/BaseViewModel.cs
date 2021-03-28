using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Navigation_Parameters_Prism_Xamarin.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {

        protected INavigationService NavigationService { get; }

        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
