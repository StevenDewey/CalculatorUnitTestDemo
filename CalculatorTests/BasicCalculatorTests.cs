using System;
using System.Collections.Generic;
using System.IO;
using Calculator;
using Moq;
using NUnit.Framework;

namespace CalculatorTests
{
    class BasicCalculatorTests
    {
        BasicCalculator calculator;
        Mock<ICalculatorService> mockCalcService;

        [SetUp]
        public void SetUp()
        {
            mockCalcService = new Mock<ICalculatorService>();
            calculator = new BasicCalculator(mockCalcService.Object);
        }

        [Test]
        public void AdditionTest()
        {
            var response = calculator.Addition(3.2, 4.8);
            Assert.IsNotNull(response);
            Assert.AreEqual(8, response);
        }

        [Test]
        public void SubtractionTest()
        {
            var response = calculator.Subtraction(3.2, 8.5);
            Assert.IsNotNull(response);
            Assert.AreEqual(-5.3, response);
        }

        [Test]
        public void MultiplicationTest()
        {
            var response = calculator.Multiplication(3.2, 2);
            Assert.IsNotNull(response);
            Assert.AreEqual(6.4, response);
        }

        [Test]
        public void DivisionTest()
        {
            var response = calculator.Division(9, 3);
            Assert.IsNotNull(response);
            Assert.AreEqual(3, response);
        }

        //[Test]
        //public void SquaredTest()
        //{
            
        //}

        //[Test]
        //public void CubedTest()
        //{
        //    var response = calculator.Cubed(3);
        //    Assert.IsNotNull(response);
        //    Assert.AreEqual(27, response);
        //}

        [Test]
        public void GoodPlusOneTest()
        {
            mockCalcService.Setup(x => x.GetCurrentValue()).Returns(2); //talk about purpose of this
            var response = calculator.AddOne();
            Assert.IsNotNull(response);
            Assert.AreEqual(3, response);
        }
        //[Test]
        //public void DbErrorPlusOneTest()
        //{
        //    mockCalcService.Setup(x => x.GetCurrentValue()).Throws(new IOException()); 
        //    Assert.Throws<Exception>(() => calculator.AddOne());
        //}
    }
}
