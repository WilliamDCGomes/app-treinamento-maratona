using System;
using MaratonaTreinamento.Views;
using Xamarin.Forms;

namespace MaratonaTreinamento
{
    public partial class App : Application
    {
        public static int ListType;
        public App()
        {
            InitializeComponent();
            ListType = 0;
            MainPage = new NavigationPage(new Login())
            {
                BarBackgroundColor = Color.FromHex("#0D1117"),
                BarTextColor = Color.White
            };
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
