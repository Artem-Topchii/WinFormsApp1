using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        private char[] _firstArray = new char[10];
        private char[] _secondArray = new char[10];
        private static bool _isPlus;
        private static bool _isMinus;
        private int _firstcount = 0;
        private int _secondcount = 0;

        public static bool IsPlus => _isPlus;
        public static bool IsMinus => _isMinus;

        public string firstValue => new string(_firstArray);
        public string secondValue => new string(_secondArray);

        LabelText labelTextValue = new LabelText();
        
        public Calculator()
        {
            InitializeComponent();
        }
        public void Cleardata(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {

            }
        }
        public void EquationText(char value)
        {
            labelTextValue.EditLabelText(value);

            labelEquation.Text = labelTextValue.LabelTextValue;
        }
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            Calculation calculation = new Calculation(firstValue, secondValue);

            labelResult.Text = calculation.Result;
        }

        public void AddToFirstArray(char number)
        {
            _firstArray[_firstcount] = number;
            _firstcount++;
        }
        public void AddToSecondArray(char number)
        {
            _secondArray[_secondcount] = number;
            _secondcount++;
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _isPlus = true;
            EquationText('+');
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _isMinus = true;
            EquationText('-');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('1');
            }
            else
            {
                AddToSecondArray('1');
            }
            EquationText('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('2');
            }
            else
            {
                AddToSecondArray('2');
            }
            EquationText('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('3');
            }
            else
            {
                AddToSecondArray('3');
            }
            EquationText('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('4');
            }
            else
            {
                AddToSecondArray('4');
            }
            EquationText('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('5');
            }
            else
            {
                AddToSecondArray('5');
            }
            EquationText('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('6');
            }
            else
            {
                AddToSecondArray('6');
            }
            EquationText('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('7');
            }
            else
            {
                AddToSecondArray('7');
            }
            EquationText('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('8');
            }
            else
            {
                AddToSecondArray('8');
            }
            EquationText('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('9');
            }
            else
            {
                AddToSecondArray('9');
            }
            EquationText('9');
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray('0');
            }
            else
            {
                AddToSecondArray('0');
            }
            EquationText('0');
        }

    }
}
