using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SmartCalculator
    {
        public double Calculate(params string[] input)
        {
            if (input.Count() == 0)
            {
                throw new Exception("No input given");
            }
            List<double> numbers = new List<double>();
            List<char> operators = new List<char>();
            var operatorIllegal = true;
            foreach (var character in input)
            {
                double num;
                char operation;
                if(double.TryParse(character, out num))
                {
                    numbers.Add(num);
                    operatorIllegal = false;
                }
                else if(char.TryParse(character, out operation))
                {
                    if (operatorIllegal)
                    {
                        throw new Exception("Can't lead with operator or Two operators in a row given");
                    }
                    operators.Add(operation);
                    operatorIllegal = true;
                }
            }
            double total = 0;
            for(var i = 1; i <= operators.Count(); i++)
            {
                var firstVal = numbers.ElementAt(i * 2 - 2);
                var secondVal = numbers.ElementAt(i * 2 - 1);
                var operation = operators.ElementAt(i -1);
                switch (operation)
                {
                    case ('+'):
                        total = firstVal + secondVal;
                        break;
                    case ('-'):
                        total = firstVal - secondVal;
                        break;
                    case ('*'):
                        total = firstVal * secondVal;
                        break;
                    case ('/'):
                        total = firstVal / secondVal;
                        break;
                    default:
                        //do nothing
                        break;
                }
            }
            return total;
        }
    }
}
