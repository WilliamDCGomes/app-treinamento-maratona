using System;
using MaratonaTreinamento.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaratonaTreinamento
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.FromHex("#0051C1"));
            MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.White);
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
