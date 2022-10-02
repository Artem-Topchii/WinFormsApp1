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
        private char [] _firstArray;
        private char [] _secondArray;
        private bool _isPlus;
        private bool _isMinus;
        public bool IsPlus => _isPlus;
        public bool IsMinus => _isMinus;

        public string firstValue => new string(_firstArray);
        public string secondValue => new string(_secondArray);
        public Calculator()
        {
            InitializeComponent();
        }
        public void AddToFirstArray(int number)
        {
            int[] firstArray = new int[10];

        }
        public void AddToSecondArray()
        {

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            _isPlus = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            _isMinus = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsMinus == false && IsPlus == false)
            {
                AddToFirstArray(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {

        }
    }
}
