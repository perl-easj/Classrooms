using System;
using System.Collections.Generic;

namespace ClassroomB
{
    public class PrimeCalc
    {
        private List<int> _primes;

        public PrimeCalc()
        {
            _primes = new List<int>();
        }

        public void FindPrimes(int upper)
        {
            _primes.Clear();

            FindPrimesInInterval(2, upper);

            string text = $"Found {_primes.Count} primes in [2; {upper}]";
            Console.WriteLine(text);
        }

        private void FindPrimesInInterval(int lower, int upper)
        {
            for (int i = lower; i < upper; i++)
            {
                if (IsPrime(i))
                {
                    _primes.Add(i);
                }
            }
        }

        private static bool IsPrime(int number)
        {
            if (number < 4) { return true; }

            int limit = Convert.ToInt32(Math.Sqrt(number));
            bool isPrime = true;

            for (int i = 2; i <= limit && isPrime; i++)
            {
                isPrime = number % i != 0;
            }

            return isPrime;
        }
    }

}