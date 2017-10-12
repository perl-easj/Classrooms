using System;

namespace ClassroomA
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncDemo aDemo = new AsyncDemo();
            aDemo.GUI();

            //PrimeCalc pCalc = new PrimeCalc();
            //pCalc.FindPrimes(1000000);

            Console.WriteLine();
            Console.WriteLine("(in Main at ReadKey...)");

            Console.ReadKey();
        }
    }
}
