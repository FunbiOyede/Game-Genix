using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameGenix
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            Application.Current.MainPage = new NavigationPage(new StartUp());
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
