using System;
using System.Collections.Generic;
using MaratonaTreinamento.Model;
using MaratonaTreinamento.Views;
using Xamarin.Forms;

namespace MaratonaTreinamento.ViewModel
{
    public class MainMenuViewModel : BaseViewModel
    {
        #region -> Propriedades <-
        private List<MasterDetailPageList> _listMainMenu = new List<MasterDetailPageList>();

        private bool _profileStandartPictureIsVisible;
        private bool _profileUserPictureIsVisible;

        #endregion


        #region -> Construtor <-
        public MainMenuViewModel()
        {
            LoadListMainMenu();
        }
        #endregion


        #region -> Encapsulamentos <-
        public List<MasterDetailPageList> ListMainMenu { get { return _listMainMenu; } set { _listMainMenu = value; OnPropertyChanged("ListMainMenu"); } }
        public bool ProfileStandartPictureIsVisible { get { return _profileStandartPictureIsVisible; } set { _profileStandartPictureIsVisible = value; OnPropertyChanged("ProfileStandartPictureIsVisible"); } }
        public bool ProfileUserPictureIsVisible { get { return _profileUserPictureIsVisible; } set { _profileUserPictureIsVisible = value; OnPropertyChanged("ProfileUserPictureIsVisible"); } }

        #endregion


        #region -> Command's <-

        #endregion


        #region -> Metodos <-
        private void LoadListMainMenu()
        {
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Exercícios", Icon = "\uf5fc", TargetType = typeof(ExerciseList) });
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Recomendados para você", Icon = "\uf14e", TargetType = typeof(ExerciseList) });
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Favoritos", Icon = "\uf005", TargetType = typeof(ExerciseList) });
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Perfíl", Icon = "\uf2bd", TargetType = typeof(RegisterScreen) });
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Sair", Icon = "\uf2f5", TargetType = typeof(VisualizeExercise) });

            _profileStandartPictureIsVisible = true;
            _profileUserPictureIsVisible = false;
    }
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
