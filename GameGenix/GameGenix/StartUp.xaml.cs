using GameGenix.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameGenix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartUp : ContentPage
    {
        public StartUp()
        {
            InitializeComponent();
            SimulateStartUp();
        }

        protected  async void SimulateStartUp()
        {
            await Task.Delay(3000);
            await this.Navigation.PushAsync(new RootPage());
        }
    }
}