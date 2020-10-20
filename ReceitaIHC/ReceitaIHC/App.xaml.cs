using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReceitaIHC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Receita.Principal();
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
