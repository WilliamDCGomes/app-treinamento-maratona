using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MaratonaTreinamento.FormattingClass
{
    public class MaskedBehavior : Behavior<Entry>
    {
        private string _mask = "";
        private string _entry = null;
        public string Mask
        {
            get => _mask;
            set
            {
                _mask = value;
                SetPositions();
            }
        }
        private bool getBack = false;
        IDictionary<int, char> _positions;

        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }


        void SetPositions()
        {
            if (string.IsNullOrEmpty(Mask))
            {
                _positions = null;
                return;
            }

            var list = new Dictionary<int, char>();
            var listAux = new List<string>();
            if (string.IsNullOrEmpty(_entry) || _mask.Equals("XX/XX/XXXX"))
            {
                for (var i = 0; i < Mask.Length; i++)
                    if (Mask[i] != 'X')
                        list.Add(i, Mask[i]);
            }
            else if (string.IsNullOrEmpty(_entry) || _mask.Equals("XX:XX:XX"))
            {
                for (var i = 0; i < Mask.Length; i++)
                    if (Mask[i] != 'X')
                        list.Add(i, Mask[i]);
            }
            else if (string.IsNullOrEmpty(_entry) || _mask.Equals("XXX.XXX.XXX-XX"))
            {
                for (var i = 0; i < Mask.Length; i++)
                    if (Mask[i] != 'X')
                        list.Add(i, Mask[i]);
            }
            else if (string.IsNullOrEmpty(_entry) || _mask.Equals("XXXXX-XXX"))
            {
                for (var i = 0; i < Mask.Length; i++)
                    if (Mask[i] != 'X')
                        list.Add(i, Mask[i]);
            }
            else
            {
                bool jump = false;
                int index = 0;
                list.Clear();
                listAux.Clear();
                for (var i = 0; i < Mask.Length; i++)
                {
                    if (jump)
                    {
                        jump = false;
                        continue;
                    }
                    else if (_entry.Trim().Length - 1 >= i && !string.IsNullOrEmpty(_entry.Substring(i, 1)))
                    {
                        if (_entry.Substring(i, 1).Equals("-") && _mask.Equals("(XX) XXXXX-XXXX"))
                        {
                            listAux.Add(_entry.Substring(i + 1, 1));
                            listAux.Add("-");
                            jump = true;
                            continue;
                        }
                        else if (getBack && i == 9)
                        {
                            listAux.Add("-");
                            listAux.Add(_entry.Substring(i, 1));
                            jump = true;
                        }
                        else
                        {
                            listAux.Add(_entry.Substring(i, 1));
                        }
                    }
                }
                _entry = "";
                foreach(string s in listAux)
                {
                    list.Add(index, char.Parse(s));
                    _entry += s;
                    index++;
                }
            }
            _positions = list;
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            var entry = sender as Entry;
            _entry = entry.Text;
            _entry?.Replace("-", "");
            string text = entry.Text;

            if (string.IsNullOrWhiteSpace(text) || _positions == null)
                return;

            if (text.Length > _mask.Length)
            {
                if (text.Length == 15 && _mask.Equals("(XX) XXXX-XXXX"))
                {
                    _mask = "(XX) XXXXX-XXXX";
                    SetPositions();
                    entry.Text = _entry;
                }
                else
                {
                    entry.Text = text.Remove(text.Length - 1);
                    return;
                }
            }
            else if (text.Length <= 14 && _mask.Equals("(XX) XXXXX-XXXX"))
            {
                _mask = "(XX) XXXX-XXXX";
                getBack = true;
                SetPositions();
                entry.Text = _entry;
                getBack = false;
            }
            else
            {
                foreach (var position in _positions)
                    if (text.Length >= position.Key + 1)
                    {
                        var value = position.Value.ToString();
                        if (text.Substring(position.Key, 1) != value)
                            text = text.Insert(position.Key, value);
                    }

                if (entry.Text != text)
                    entry.Text = text;
            }
        }
    }
}
