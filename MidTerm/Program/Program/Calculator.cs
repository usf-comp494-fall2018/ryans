using System;
using System.Collections.Generic;
using System.Text;

namespace Calc
{
    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Mean(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            sum = sum / arr.Length;
            return sum;
        }

        public double Median(double[] arr)
        {
            //Sort array
            double[] arr2 = arr;
            Array.Sort(arr2);

            //Perform arithmetic to find median
            double sum = 0;
            if (arr2.Length % 2 == 0)
            {
                sum = sum + arr2[(arr2.Length / 2)];
                sum = sum + arr2[(arr2.Length / 2) - 1];
                sum = sum / 2;

                return sum;
            }
            else
            {
                return arr2[(arr2.Length / 2)];
            }
        }


    }
}
