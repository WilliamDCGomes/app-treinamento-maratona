using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
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
        private async void CallRegisterScreen()
        {
            UserDialogs.Instance.ShowLoading("");
            await Task.Delay(100);
            await _navigation.PushAsync(new RegisterScreen());
            UserDialogs.Instance.HideLoading();
        }

        [Obsolete]
        private async void CallMainMenu()
        {
            UserDialogs.Instance.ShowLoading("");
            await Task.Delay(100);
            App.Current.MainPage = new NavigationPage(new MainMenu());
            UserDialogs.Instance.HideLoading();
        }
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
