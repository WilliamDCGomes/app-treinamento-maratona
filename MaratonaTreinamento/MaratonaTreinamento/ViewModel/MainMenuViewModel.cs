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
        #endregion


        #region -> Construtor <-
        public MainMenuViewModel()
        {
            LoadListMainMenu();
        }
        #endregion


        #region -> Encapsulamentos <-
        public List<MasterDetailPageList> ListMainMenu { get { return _listMainMenu; } set { _listMainMenu = value; OnPropertyChanged("ListMainMenu"); } }
        #endregion


        #region -> Command's <-

        #endregion


        #region -> Metodos <-
        private void LoadListMainMenu()
        {
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Exercícios", Icon = "\uf5fc", TargetType = typeof(ExerciseList) });
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Recomendados para você", Icon = "\uf14e", TargetType = typeof(ExerciseList) });
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Favoritos", Icon = "\uf005", TargetType = typeof(ExerciseList) });
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Perfíl", Icon = "\uf2bd", TargetType = typeof(ExerciseList) });
            _listMainMenu.Add(new MasterDetailPageList() { Title = "Sair", Icon = "\uf2f5", TargetType = typeof(ExerciseList) });
        }
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
