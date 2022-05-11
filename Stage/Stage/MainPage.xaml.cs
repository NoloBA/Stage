using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Stage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //auto go to page, usgh for for splashscreeen
        /*async protected override void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(6000);

            await Navigation.PushAsync(new Signup());
        }*/

        private async void SignUpButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup());

        }
    }
}
