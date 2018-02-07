using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IBasicCalculator
    {
        double Addition(double x, double y);
        double Subtraction(double x, double y);
        double Multiplication(double x, double y);
        double Division(double x, double y);
        double AddOne();
    }
    public class BasicCalculator : IBasicCalculator
    {
        ICalculatorService CalcService;
        public BasicCalculator(ICalculatorService calcService)
        {
            CalcService = calcService;
        }
        public double Addition(double x, double y)
        {
            return x + y;
        }
        public double Subtraction(double x, double y)
        {
            return x - y;
        }
        public double Multiplication(double x, double y)
        {
            return x * y;
        }
        public double Division(double x, double y)
        {
            if(y == 0)
            {
                return 0;
            }
            return x / y;
        }

        //public double Squared(double x)
        //{
        //    return x * x;
        //}
        //public double Cubed(double x)
        //{
        //    return default(double);
        //}


        public double AddOne()
        {
            double currentVal = CalcService.GetCurrentValue();
            currentVal = currentVal + 1;
            CalcService.SetCurrentValue(currentVal);
            return currentVal;
        }
        //public double AddOne()
        //{
        //    double currentVal;
        //    try
        //    {
        //        currentVal = CalcService.GetCurrentValue();
        //        currentVal = currentVal + 1;
        //        CalcService.SetCurrentValue(currentVal);
        //    }
        //    catch(Exception ex)
        //    {
        //        //perform some logging
        //        throw new Exception("Error connecting with Database in AddOne method", ex);
        //    }

        //    return currentVal;
        //}
    }
}
