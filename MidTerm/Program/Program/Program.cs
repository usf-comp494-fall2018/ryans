using System;
using Calc;
using System.IO;


/*
 *          Author:     Ryan Schuda
 *          Title:      Midterm
 *          Purpose:    Calculator, Means and Medians
 *          
 */
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Open file, read into an array
            StreamReader readIn = File.OpenText("CalcInput.txt");
            var count = File.ReadAllLines("CalcInput.txt").Length;
            double[] numbs = new double[count+1];

            while (!readIn.EndOfStream)
            {
                numbs[count]=double.Parse(readIn.ReadLine());
                count++;
            }

            //Initialize calculator, call Mean and Median functions
            Calculator calc = new Calculator();
            double mean = calc.Mean(numbs);
            double median = calc.Median(numbs);

            //Output to file
            StreamWriter writeOut = new StreamWriter("CalcOutput.txt");
            writeOut.WriteLine("The mean of the inputted values is: " + mean);
            writeOut.WriteLine("The median of the inputted values is: " + median);
            writeOut.Close();
        }
    }
}
