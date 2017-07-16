using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorShould
    {
        private Calculator _calculator;

        public CalculatorShould()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void AddTwoInegers()
        {
            int sum = _calculator.Add(54, 29);

            Assert.Equal(sum, 83);

        }

        [Fact]
        public void SubtractTwoInts ()
        {
            int sum = _calculator.Sub(12, 2);
            Assert.Equal(sum, 10);
        }
    }
}
