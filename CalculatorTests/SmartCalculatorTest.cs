using System;
using System.Collections.Generic;
using Calculator;
using NUnit.Framework;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        SmartCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new SmartCalculator();
        }
        [Test]
        public void SimpleAdditionTest()
        {
            var response = calculator.Calculate("5", "+", "2");
            Assert.IsNotNull(response);
            Assert.AreEqual(7, response);
        }
        //[Test]
        //public void NoParamsTest()
        //{
        //    Assert.Throws<Exception>(() => calculator.Calculate());
        //}
        //[Test]
        //public void TooManyOperationsTest()
        //{
        //    //var response = calculator.Calculate("5", "+", "+", "5");
            
        //    Assert.Throws<Exception>(() => calculator.Calculate("5", "+", "+", "5"));
        //}
        //[Test]
        //public void LeadingWithOperatorTest()
        //{
        //    //var response = calculator.Calculate("*", "5", "+", "5");
            
        //    Assert.Throws<Exception>(() => calculator.Calculate("*", "5", "+", "5"));
        //}
    }
}
