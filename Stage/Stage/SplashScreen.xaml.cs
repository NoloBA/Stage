using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

            protected async override void OnAppearing()
            {
                base.OnAppearing();

                await Task.Delay(6000);

                await Navigation.PushAsync(new MainPage());
            }
   
    }
}