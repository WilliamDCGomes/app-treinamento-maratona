using System;
using MaratonaTreinamento.Views;
using Xamarin.Forms;

namespace MaratonaTreinamento.ViewModel
{
    public class LoginScreenViewModel : BaseViewModel
    {
        #region -> Propriedades <-
        private Command _goToRegistrScreen;
        private Command _goToMainMenu;

        private INavigation _navigation;
        #endregion


        #region -> Construtor <-
        public LoginScreenViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }
        #endregion


        #region -> Encapsulamentos <-

        #endregion


        #region -> Command's <-
        public Command GoToRegistrScreen => _goToRegistrScreen ?? (_goToRegistrScreen = new Command(() => CallRegisterScreen()));
        public Command GoToMainMenu => _goToMainMenu ?? (_goToMainMenu = new Command(() => CallMainMenu()));
        #endregion


        #region -> Metodos <-
        private void CallRegisterScreen()
        {
            _navigation.PushAsync(new RegisterScreen());
        }
        private void CallMainMenu()
        {
            App.Current.MainPage = new NavigationPage(new MainMenu());
        }
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
