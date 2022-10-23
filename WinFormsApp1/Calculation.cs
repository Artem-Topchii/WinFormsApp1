using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Calculation
    {

        public string Result;

        public Calculation(string firstValue, string secondValue)
        {
            int result = 0;
            int firstnumber = Convert.ToInt32(firstValue);
            int secondnumber = Convert.ToInt32(secondValue);

            if (Calculator.IsPlus == true)
            {
                result = firstnumber + secondnumber;
            }
            if (Calculator.IsMinus == true)
            {
                result = firstnumber - secondnumber;
            }

            Result = result.ToString();
        }
    }
}
