using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ClassroomB
{
    class Program
    {
        private static Random _generator = new Random();

        static void Main(string[] args)
        {
            AsyncDemo aDemo = new AsyncDemo();
            aDemo.DoDemo();

            Console.WriteLine("Done - press any key to shut down the app");
            Console.ReadKey();
        }

        private static void TestAverageCalc()
        {
            List<int> lotsOfNumbers = new List<int>();
            const int noOfNumbers = 10000000;
            AverageCalculator avCalc = new AverageCalculator();

            Console.WriteLine("Generating random numbers...");
            for (int i = 0; i < noOfNumbers; i++)
            {
                lotsOfNumbers.Add(_generator.Next(Int32.MaxValue));
            }
            Console.WriteLine("Done, starting calculation...");


            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            Task taskUI = new Task(() =>
            {
                Console.WriteLine("Type c for cancel");
                string userInput = Console.ReadLine();
                if (userInput == "c")
                {
                    tokenSource.Cancel();
                }
            });
            taskUI.Start();

            Int64 average = avCalc.AverageAsTask(lotsOfNumbers, token);
            Console.WriteLine($"Average of {noOfNumbers} numbers is {average}");
        }

        private static void TestPrimeCalc()
        {
            PrimeCalc prCalc = new PrimeCalc();
            prCalc.FindPrimes(1000000);
        }
    }
}
