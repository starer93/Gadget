using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gadge
{
    class Calculator
    {
        private string[] parts;
        private List<double> numbers = new List<double>();
        private List<string> brack = new List<string>();
        private List<string> operators = new List<string>();

        private char[] delimiters = new char[] { '/', '%','+', '-', '(', ')' };


        public string calculate(string input)
        {
            string[] parts = input.Split(delimiters,
                                 StringSplitOptions.RemoveEmptyEntries);

        for(int i = 0 ; i < parts.Length; i++)
        {
            if(parts[i].Equals("(") || parts[i].Equals(")"))
            {

            }
            else if(parts[i].Equals("+") || parts[i].Equals("-") || parts[i].Equals("*") || parts[i].Equals("/"))
            {
                operators.Add(parts[i]);
            }
            else
            {
                double n;
                bool isNumeric = double.TryParse(parts[i], out n);
                if(isNumeric == true)
                {
                    numbers.Add(n);
                }
            }
        }
            string result = parts.ToString();
            return result;
        }

        private void operate(double input1, double input2, string symbol)
        {

        }

    }
}
