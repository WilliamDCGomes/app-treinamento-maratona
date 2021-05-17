using System;
namespace MaratonaTreinamento.FormattingClass
{
    public static class MaskedFormatting
    {
        public static string MaskToPhone(string _phone)
        {
            string aux = "";
            string saveAux = "";
            bool validation = false;
            if (_phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Length > 10)
            {
                aux = _phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                _phone = "";
                for (int i = 0; i < 10; i++)
                {
                    _phone += aux.Substring(i, 1);
                }
            }
            aux = "";
            _phone = _phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            for (int i = 0; i < _phone.Length; i++)
            {
                if (i == 0 && !_phone.Substring(i, 1).Equals("("))
                {
                    aux = "(" + _phone;
                    _phone = aux;
                }
                else if (i == 3 && !_phone.Substring(i, 1).Equals(")"))
                {
                    aux = _phone.Substring(0, 3) + ") " + _phone.Substring(3, _phone.Length - 3);
                    _phone = aux;
                }
                else if (i == 9 && !_phone.Substring(i, 1).Equals("-")
                         && _phone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Length > 6)
                {
                    aux = _phone.Substring(0, 9) + "-" + _phone.Substring(9, _phone.Length - 9);
                    _phone = aux;
                }
            }
            return _phone;
        }

        public static string MaskToCellPhone(string _cellPhone)
        {
            string aux = "";
            string saveAux = "";
            bool validation = false;
            if(_cellPhone.Replace("(","").Replace(")", "").Replace(" ", "").Replace("-", "").Length > 11)
            {
                aux = _cellPhone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
                _cellPhone = "";
                for(int i = 0; i < 11; i++)
                {
                    _cellPhone += aux.Substring(i, 1);
                }
            }
            aux = "";
            _cellPhone = _cellPhone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "");
            for (int i = 0; i < _cellPhone.Length; i++)
            {
                if(i == 0 && !_cellPhone.Substring(i, 1).Equals("("))
                {
                    aux = "(" + _cellPhone;
                    _cellPhone = aux;
                }
                else if(i == 3 && !_cellPhone.Substring(i, 1).Equals(")"))
                {
                    aux = _cellPhone.Substring(0, 3) + ") " + _cellPhone.Substring(3, _cellPhone.Length - 3);
                    _cellPhone = aux;
                }
                else if (i == 9 && !_cellPhone.Substring(i, 1).Equals("-")
                         && _cellPhone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Length > 6
                         && _cellPhone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Length < 11)
                {
                    aux = _cellPhone.Substring(0, 9) + "-" + _cellPhone.Substring(9, _cellPhone.Length - 9);
                    _cellPhone = aux;
                }
                else if (i == 10 && !_cellPhone.Substring(i, 1).Equals("-")
                         && _cellPhone.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", "").Length >= 11)
                {
                    aux = _cellPhone.Substring(0, 10) + "-" + _cellPhone.Substring(10, _cellPhone.Length - 10);
                    _cellPhone = aux;
                }
            }
            return _cellPhone;
        }
    }
}
