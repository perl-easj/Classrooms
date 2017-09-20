using System;
using System.Diagnostics;

namespace ClassroomA
{
    public class TimedTester
    {
        private static Stopwatch _watch = new Stopwatch();

        /// <summary>
        /// Measures the execution time for "iterations" invocations
        /// of the given method
        /// </summary>
        public static long MeasureRunTimeLoop(int iterations, Action functionToTest)
        {
            _watch.Restart();
            for (int i = 0; i < iterations; i++)
            {
                functionToTest();
            }
            _watch.Stop();

            return _watch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Measures the execution time for a single invocation
        /// of the given method
        /// </summary>
        public static long MeasureRunTime(Action functionToTest)
        {
            return MeasureRunTimeLoop(1, functionToTest);
        }
    }
}