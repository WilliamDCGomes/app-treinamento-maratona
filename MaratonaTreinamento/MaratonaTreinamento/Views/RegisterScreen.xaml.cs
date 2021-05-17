using System;
using System.Collections.Generic;
using MaratonaTreinamento.ViewModel;
using Xamarin.Forms;

namespace MaratonaTreinamento.Views
{
    public partial class RegisterScreen : ContentPage
    {
        private RegisterScreenViewModel _registerScreenViewModel;
        public RegisterScreen()
        {
            InitializeComponent();

            _registerScreenViewModel = new RegisterScreenViewModel();
            BindingContext = _registerScreenViewModel;
        }

        void CustomEntry_Completed(System.Object sender, System.EventArgs e)
        {
        }

        void PhoneChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            _registerScreenViewModel.MaskToPhone(EntryPhone.CursorPosition);
        }

        void CellPhoneChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            _registerScreenViewModel.MaskToCellPhone(EntryCellPhone.CursorPosition);
        }
    }
}
