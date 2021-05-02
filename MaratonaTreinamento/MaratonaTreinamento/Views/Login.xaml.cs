using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MaratonaTreinamento.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            buttonsAnimation();
        }

        async void buttonsAnimation()
        {
            if (DevicePlatform.Android == DeviceInfo.Platform)
            {
                versionText.TranslationY = -3000;
                buttonCadastre.TranslationY = -3000;
                buttonLogin.TranslationY = -3000;
                frameApple.TranslationY = -3000;
                frameFace.TranslationY = -3000;
                frameGoogle.TranslationY = -3000;
                secondText.TranslationY = -3000;
                firstText.TranslationY = -3000;

                await versionText.TranslateTo(0, 0, 150, Easing.BounceOut);
                await buttonCadastre.TranslateTo(0, 0, 150, Easing.BounceOut);
                await buttonLogin.TranslateTo(0, 0, 150, Easing.BounceOut);
                await frameApple.TranslateTo(0, 0, 150, Easing.BounceOut);
                await frameFace.TranslateTo(0, 0, 150, Easing.BounceOut);
                await frameGoogle.TranslateTo(0, 0, 150, Easing.BounceOut);
                await secondText.TranslateTo(0, 0, 150, Easing.BounceOut);
                await firstText.TranslateTo(0, 0, 150, Easing.BounceOut);
            }
            else if (DevicePlatform.iOS == DeviceInfo.Platform)
            {
                versionText.TranslationX = 3000;
                buttonCadastre.TranslationX = -3000;
                buttonLogin.TranslationX = 3000;
                frameApple.TranslationX = -3000;
                frameFace.TranslationX = 3000;
                frameGoogle.TranslationX = -3000;
                secondText.TranslationX = 3000;
                firstText.TranslationX = -3000;

                await firstText.TranslateTo(0, 0, 150, Easing.BounceOut);
                await secondText.TranslateTo(0, 0, 150, Easing.BounceOut);
                await frameGoogle.TranslateTo(0, 0, 150, Easing.BounceOut);
                await frameFace.TranslateTo(0, 0, 150, Easing.BounceOut);
                await frameApple.TranslateTo(0, 0, 150, Easing.BounceOut);
                await buttonLogin.TranslateTo(0, 0, 150, Easing.BounceOut);
                await buttonCadastre.TranslateTo(0, 0, 150, Easing.BounceOut);
                await versionText.TranslateTo(0, 0, 150, Easing.BounceOut);
            }
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
