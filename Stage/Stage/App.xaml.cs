using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new MainPage();
            var navigationPage = new NavigationPage(new MainPage());  
            //var can be removed here
            navigationPage.BarBackgroundColor = Color.Purple;

            MainPage = navigationPage;
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
