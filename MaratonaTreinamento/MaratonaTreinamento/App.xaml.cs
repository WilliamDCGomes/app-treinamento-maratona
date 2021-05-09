﻿using System;
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
