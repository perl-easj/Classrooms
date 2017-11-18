using System;
using System.Runtime.CompilerServices;
// ReSharper disable RedundantAssignment

// ReSharper disable UnusedParameter.Local
#pragma warning disable 4014

namespace ClassRoomD
{
    class Program
    {
        static void Main(string[] args)
        {
            PulseGenerator theGenerator = new PulseGenerator();
            theGenerator.Pulse += CallMe;
            theGenerator.Pulse += CallMe2;

            theGenerator.PulseWithCount += CallMeWithCount;

            // Assign methods to Pulsegenerator events

            theGenerator.Start(400, 10);

            Console.WriteLine("You can close the App by pressing any key...");
            Console.ReadKey();
        }

        public static void CallMe()
        {
            Console.WriteLine("I was called!");
        }

        public static void CallMe2()
        {
            Console.WriteLine("I was ALSO called!");
        }

        public static void CallMeWithCount(int count)
        {
            Console.WriteLine($"I was called with count {count}!");
        }
    }
}
