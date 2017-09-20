using System;
using System.Collections.Generic;

// ReSharper disable UnusedParameter.Local


namespace ClassroomA
{
    class Program
    {
        private static Random _generator = new Random();

        static void Main(string[] args)
        {
            #region Setup
            const int noOfNumbers = 1000;
            const int noOfLinearSearches = 1000;
            const int noOfBinarySearches = 1000000;

            List<int> numbers = new List<int>();
            for (int i = 0; i < noOfNumbers; i++)
            {
                numbers.Add(_generator.Next(Int32.MaxValue));
            }
            #endregion

            #region Lineær søgning
            long runTimeLinear = TimedTester.MeasureRunTimeLoop(noOfLinearSearches, () =>
                {
                    int valueToLookFor = _generator.Next(Int32.MaxValue);
                    bool found = false;
                    for (int index = 0; index < numbers.Count && !found; index++)
                    {
                        found = (numbers[index] == valueToLookFor);
                    }
                }
            );
            Console.WriteLine($"Lineær søgning tog {(runTimeLinear * 1000) / noOfLinearSearches} mikro-sekunder.");
            #endregion

            #region Sortering
            long runTimeSort = TimedTester.MeasureRunTime(() =>
                {
                    numbers.Sort();
                }
            );
            Console.WriteLine($"Sortering tog {runTimeSort} milli-sekunder.");
            #endregion

            #region Binær søgning
            long runTimeBinary = TimedTester.MeasureRunTimeLoop(noOfBinarySearches, () =>
                {
                    int valueToLookFor = _generator.Next(Int32.MaxValue);
                    int index = numbers.BinarySearch(valueToLookFor);
                }
            );
            Console.WriteLine($"Binær søgning tog {(runTimeBinary * 1000000) / noOfBinarySearches} nano-sekunder.");
            #endregion

            #region Kald af rekursive metoder
            PrintHello(10);

            Console.WriteLine($"8! = {Factorial(8)}");

            TowersOfHanoi("A", "B", "C", 4); 
            #endregion

            Console.WriteLine("Done - press any key to shut down the app");
            Console.ReadKey();
        }

        #region Definition af rekursive metoder
        public static void PrintHello()
        {
            Console.WriteLine("Hello");
            PrintHello();
        }

        public static void PrintHello(int numberOfCallsLeft)
        {
            if (numberOfCallsLeft > 0)
            {
                Console.WriteLine("Hello");
                PrintHello(numberOfCallsLeft - 1);
            }
        }

        public static int Factorial(int n)
        {
            return (n <= 1) ? 1 : (n * Factorial(n - 1));
        }

        public static void TowersOfHanoi(string pegA, string pegB, string pegC, int n)
        {
            if (n > 0)
            {
                TowersOfHanoi(pegA, pegC, pegB, n - 1);
                Console.WriteLine("Move disk " + n + ": " + pegA + "->" + pegC);
                TowersOfHanoi(pegB, pegA, pegC, n - 1);
            }
        } 
        #endregion
    }
}
