using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculatorService
    {
        void SetCurrentValue(double currentVal);
        double GetCurrentValue();
    }
    public class CalculatorService : ICalculatorService
    {
        public void SetCurrentValue(double currentVal)
        {
            //save in db
        }

        public double GetCurrentValue()
        {
            //go to db and get current value
            //for now return random number 
            Random rnd = new Random();
            return rnd.Next(-100, 100);
        }
    }
}
