using System;
using MaratonaTreinamento.FormattingClass;
using Xamarin.Forms;

namespace MaratonaTreinamento.ViewModel
{
    public class RegisterScreenViewModel : BaseViewModel
    {
        #region -> Propriedades <-
        //private Command _goToRegistrScreen;
        private string _phone;
        private string _cellPhone;
        //private int _cursorPhone;
        //private int _cursorCellPhone;
        #endregion


        #region -> Construtor <-
        public RegisterScreenViewModel()
        {
            _phone = "";
            _cellPhone = "";
    }
        #endregion


        #region -> Encapsulamentos <-
        public string Phone { get { return _phone; } set { _phone = value; OnPropertyChanged("Phone"); } }
        public string CellPhone { get { return _cellPhone; } set { _cellPhone = value; OnPropertyChanged("CellPhone"); } }
        //public int CursorPhone { get { return _cursorPhone; } set { _cursorPhone = value; OnPropertyChanged("CursorPhone"); } }
        //public int CursorCellPhone { get { return _cursorCellPhone; } set { _cursorCellPhone = value; OnPropertyChanged("CursorCellPhone"); } }
        #endregion


        #region -> Command's <-
        //public Command GoToRegistrScreen => _goToRegistrScreen ?? (_goToRegistrScreen = new Command(async () => CallRegisterScreen()));
        #endregion


        #region -> Metodos <-
        public void MaskToPhone()
        {
            _phone = MaskedFormatting.MaskToPhone(_phone);
            OnPropertyChanged("Phone");
        }

        public void MaskToCellPhone()
        {
            _cellPhone = MaskedFormatting.MaskToCellPhone(_cellPhone);
            OnPropertyChanged("CellPhone");
        }
        #endregion


        #region -> Enuns <-

        #endregion
    }
}
