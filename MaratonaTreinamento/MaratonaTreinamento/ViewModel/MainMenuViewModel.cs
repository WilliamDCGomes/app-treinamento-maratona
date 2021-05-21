using System;
using System.Collections.Generic;
using MaratonaTreinamento.Model;

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
            _listMainMenu.Add(new MasterDetailPageList("&#xf5fc;", "Exercícios"));
        }
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
