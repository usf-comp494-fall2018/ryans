using System;
using Xunit;
using Calc;

namespace CalcTest
{
    public class UnitTest1
    {
        [Fact]
        public void Median1()
        {
            double[] arr = new double[] { 20.2, 12, 43.4 };
            Calculator calc = new Calculator();
            double median = calc.Median(arr);
            double truevalue = 20.2;
            Assert.Equal(truevalue, median);
        }

        [Fact]
        public void Median2()
        {
            double[] arr = new double[] { 98.3,79.2,9.3,9.1,1.1,2.7 };
            Calculator calc = new Calculator();
            double median = calc.Median(arr);
            double truevalue = 9.2;
            Assert.Equal(truevalue, median);
        }

        [Fact]
        public void Mean1()
        {
            double[] arr = new double[] { 20.2, 12, 43.4 };
            Calculator calc = new Calculator();
            double mean = calc.Mean(arr);
            double truevalue = 25.2;
            Assert.Equal(truevalue, mean, 2);
        }
        [Fact]
        public void Mean2()
        {
            double[] arr = new double[] { 98.3, 79.2, 9.3, 9.1, 1.1, 2.7 };
            Calculator calc = new Calculator();
            double mean = calc.Mean(arr);
            double truevalue = 33.28;
            Assert.Equal(truevalue, mean, 2);
        }
    }
}
