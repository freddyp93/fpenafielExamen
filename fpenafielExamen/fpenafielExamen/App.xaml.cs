using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fpenafielExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Llamo a la ventana de login
            MainPage = new NavigationPage(new login());
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
