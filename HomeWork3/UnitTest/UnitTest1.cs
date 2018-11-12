using System;
using Xunit;
using Calc;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Add1()
        {
            int num1 = 7;
            int num2 = 8;
            Calculator calc = new Calculator();
            double total = calc.Add(num1,num2);
            double truevalue = 15;
            Assert.Equal(truevalue, total);
        }

        [Fact]
        public void Add2()
        {
            int num1 = 17;
            int num2 = 3;
            Calculator calc = new Calculator();
            double total = calc.Add(num1, num2);
            double truevalue = 20;
            Assert.Equal(truevalue, total);
        }

        [Fact]
        public void Sub1()
        {
            int num1 = 17;
            int num2 = 3;
            Calculator calc = new Calculator();
            double total = calc.Subtract(num1, num2);
            double truevalue = 14;
            Assert.Equal(truevalue, total);
        }

        [Fact]
        public void Sub2()
        {
            int num1 = 7;
            int num2 = 10;
            Calculator calc = new Calculator();
            double total = calc.Subtract(num1, num2);
            double truevalue = -3;
            Assert.Equal(truevalue, total);
        }

        [Fact]
        public void Mult1()
        {
            int num1 = 7;
            int num2 = 10;
            Calculator calc = new Calculator();
            double total = calc.Multiply(num1, num2);
            double truevalue = 70;
            Assert.Equal(truevalue, total);
        }

        [Fact]
        public void Mult2()
        {
            int num1 = 6;
            int num2 = 5;
            Calculator calc = new Calculator();
            double total = calc.Multiply(num1, num2);
            double truevalue = 30;
            Assert.Equal(truevalue, total);
        }

        [Fact]
        public void Divide1()
        {
            int num1 = 60;
            int num2 = 10;
            Calculator calc = new Calculator();
            double total = calc.Divide(num1, num2);
            double truevalue = 6;
            Assert.Equal(truevalue, total);
        }

        [Fact]
        public void Divide2()
        {
            int num1 = 20;
            int num2 = 4;
            Calculator calc = new Calculator();
            double total = calc.Divide(num1, num2);
            double truevalue = 5;
            Assert.Equal(truevalue, total);
        }
    }
}
