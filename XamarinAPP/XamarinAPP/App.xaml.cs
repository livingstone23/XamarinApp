using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinAPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new ViewPage.SegundaPagina());
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
