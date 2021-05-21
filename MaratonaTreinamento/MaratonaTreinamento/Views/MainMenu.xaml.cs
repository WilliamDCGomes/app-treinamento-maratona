using System;
using System.Collections.Generic;
using MaratonaTreinamento.Model;
using MaratonaTreinamento.ViewModel;
using Xamarin.Forms;

namespace MaratonaTreinamento.Views
{
    [Obsolete]
    public partial class MainMenu : Shell
    {
        private MainMenuViewModel _mainMenuViewModel;
        public MainMenu()
        {
            InitializeComponent();
            _mainMenuViewModel = new MainMenuViewModel();
            BindingContext = _mainMenuViewModel;
        }

        void itemFromMenuselected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            
        }
    }
}
