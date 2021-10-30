using System;
using System.Collections.Generic;
using MaratonaTreinamento.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaratonaTreinamento.Views
{
    public partial class LoginScreen : ContentPage
    {
        LoginScreenViewModel _loginScreenViewModel;
        public LoginScreen()
        {
            InitializeComponent();
            _loginScreenViewModel = new LoginScreenViewModel(this.Navigation);
            BindingContext = _loginScreenViewModel;
        }
    }
}
