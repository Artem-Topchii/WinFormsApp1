using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class LabelText
    {
        private int _textcount = 0;
        private char[] _text = new char[20];
        public string LabelTextValue => new string(_text);
        public LabelText()
        {
        }
        public void EditLabelText(char value)
        {
            _text[_textcount] = value;
            _textcount++;   
        }
    }
}
