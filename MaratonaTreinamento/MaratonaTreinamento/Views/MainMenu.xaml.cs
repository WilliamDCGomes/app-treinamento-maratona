using System;
using System.Collections.Generic;
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

        void MenuItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var item = (MasterDetailPageList)e.SelectedItem;
            if (item == null)
                return;
            (sender as ListView).SelectedItem = null;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
