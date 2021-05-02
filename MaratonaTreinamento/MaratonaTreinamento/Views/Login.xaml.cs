using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MaratonaTreinamento.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void SingInWithGoogle(System.Object sender, System.EventArgs e)
        {
            await frameGoogle.FadeTo(0.5, 100, Easing.BounceIn);
            await frameGoogle.FadeTo(1, 100, Easing.BounceOut);
        }

        async void SingInWithFacebook(System.Object sender, System.EventArgs e)
        {
            await frameFace.FadeTo(0.5, 100, Easing.BounceIn);
            await frameFace.FadeTo(1, 100, Easing.BounceOut);
        }

        async void SingInWithApple(System.Object sender, System.EventArgs e)
        {
            await frameApple.FadeTo(0.5, 100, Easing.BounceIn);
            await frameApple.FadeTo(1, 100, Easing.BounceOut);
        }

        void EnterLogin(System.Object sender, System.EventArgs e)
        {

        }

        void NewUser(System.Object sender, System.EventArgs e)
        {

        }
    }
}
