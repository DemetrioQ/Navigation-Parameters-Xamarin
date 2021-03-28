using Navigation_Parameters_Prism_Xamarin.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation_Parameters_Prism_Xamarin
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync($"/{Config.MainTabbedPage}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>(Config.NavigationPage);
            containerRegistry.RegisterForNavigation<MainTabbedPage>(Config.MainTabbedPage);
            containerRegistry.RegisterForNavigation<HomePage>(Config.HomePage);
            containerRegistry.RegisterForNavigation<DetailPage>(Config.DetailPage);
        }
    }
}
