using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin_fridge_organizer.Services;
using xamarin_fridge_organizer.Views;

namespace xamarin_fridge_organizer
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
