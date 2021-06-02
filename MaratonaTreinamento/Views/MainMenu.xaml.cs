using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MaratonaTreinamento.Model;
using MaratonaTreinamento.ViewModel;
using Xamarin.Forms;

namespace MaratonaTreinamento.Views
{
    [Obsolete]
    public partial class MainMenu : MasterDetailPage
    {
        private MainMenuViewModel _mainMenuViewModel;
        public MainMenu()
        {
            InitializeComponent();
            _mainMenuViewModel = new MainMenuViewModel();
            BindingContext = _mainMenuViewModel;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ExerciseList)));
        }

        async void MenuItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var item = (MasterDetailPageList)e.SelectedItem;
            if (item == null)
                return;
            UserDialogs.Instance.ShowLoading("");
            (sender as ListView).SelectedItem = null;
            Type page = item.TargetType;
            if (item.Title.Equals("Exercícios"))
                App.ListType = 0;
            else if (item.Title.Equals("Recomendados para você"))
                App.ListType = 1;
            else if (item.Title.Equals("Favoritos"))
                App.ListType = 2;
            else if (item.Title.Equals("Sair"))
            {
                if (await Application.Current.MainPage.DisplayAlert("Atenção!", "Deseja realmente sair?", "Sim", "Não"))
                {
                    Application.Current.MainPage = new NavigationPage(new Login());
                }
                UserDialogs.Instance.HideLoading();
                return;
            }
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
            UserDialogs.Instance.HideLoading();
        }
    }
}
