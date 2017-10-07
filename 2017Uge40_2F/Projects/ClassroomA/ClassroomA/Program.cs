using System;
using System.Collections.Generic;
using System.Diagnostics;

// ReSharper disable UnusedParameter.Local


namespace ClassroomA
{
    class Program
    {
        private static Random _generator = new Random();

        static void Main(string[] args)
        {
            List<int> lotsOfNumbers = new List<int>();
            const int noOfNumbers = 100000000;
            Stopwatch watch = new Stopwatch();
            AverageCalculator avCalc = new AverageCalculator();

            Console.WriteLine("Generating random numbers...");
            for (int i = 0; i < noOfNumbers; i++)
            {
                lotsOfNumbers.Add(_generator.Next(Int32.MaxValue));
            }
            Console.WriteLine("Done, starting calculation...");

            watch.Restart();
            Int64 average = avCalc.SmartAverage(lotsOfNumbers,100);
            watch.Stop();

            Console.WriteLine($"Average of {noOfNumbers} numbers is {average}, took {watch.ElapsedMilliseconds} ms.");


            Console.WriteLine("Done - press any key to shut down the app");
            Console.ReadKey();
        }
    }
}
