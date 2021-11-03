using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinAPP.ViewPage;

namespace XamarinAPP
{
    public partial class App : Application
    {
        public static NavigationPage Navigate { get; internal set; }
        public static PPrincipal MenuApp { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new SegundaPagina());
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
