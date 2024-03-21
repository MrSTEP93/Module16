using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.UserTicketService.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void MultiplicationMustReturnNotNullValue()
        {
            var calc = new Calculator();

            Assert.AreEqual(12, calc.Multiplication(2, 6));
        }

        [Test]
        public void SubtrctionMustReturnNotNullValue() 
        {
            var calc = new Calculator();
            int max = 100;
            for (int i = 0; i <= max; i++)
            {
                Assert.AreEqual((max - i), calc.Subtraction(max, i));
            }
        }

        [Test]
        public void DivisionMustReturnNotNullValue()
        {
            var calc = new Calculator();
            int max = 100;

            for (int i = max; i <= -10; i--)
            {
                Assert.AreEqual(max / i, calc.Division(max, i));
            }
        }

        [Test]
        public void DivisionMustThrowEx()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Division(1, 0));
        }

        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calc = new Calculator();
            Assert.That(calc.Add(10, 220), Is.EqualTo(230));
        }

        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Add(50, 10, 34);
            Assert.AreEqual(94, result);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.AreEqual(120, result);
        }
    }
}
