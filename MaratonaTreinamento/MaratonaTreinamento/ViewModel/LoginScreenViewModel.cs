using System;
using MaratonaTreinamento.Views;
using Xamarin.Forms;

namespace MaratonaTreinamento.ViewModel
{
    public class LoginScreenViewModel : BaseViewModel
    {
        #region -> Propriedades <-
        private Command _goToRegistrScreen;

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
        public Command GoToRegistrScreen => _goToRegistrScreen ?? (_goToRegistrScreen = new Command(async () => CallRegisterScreen()));
        #endregion


        #region -> Metodos <-
        private void CallRegisterScreen()
        {
            _navigation.PushAsync(new RegisterScreen());
        }
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
