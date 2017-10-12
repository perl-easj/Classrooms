using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClassroomA
{
    public class PrimeCalc
    {
        private ConcurrentBag<int> _primes;

        public PrimeCalc()
        {
            _primes = new ConcurrentBag<int>();
        }

        public void FindPrimes(int upper)
        {
                // _primes.Clear();

            FindPrimesInInterval(2, upper);

            #region with Tasks
            int middle = upper / 2;
            Task t1 = Task.Run(() => FindPrimesInInterval(2, middle));
            Task t2 = Task.Run(() => FindPrimesInInterval(middle + 1, upper));
            t1.Wait();
            t2.Wait();
            #endregion

            Console.WriteLine($"Found {_primes.Count} primes in [2; {upper}]");
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

        private bool IsPrime(int number)
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