using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// ReSharper disable RedundantAssignment

// ReSharper disable ForCanBeConvertedToForeach

namespace ClassroomA
{
    public class AverageCalculator
    {
        private List<int> _numbers;
        private List<Int64> _sumParts;
        private int _noOfParts;

        public AverageCalculator()
        {
            _numbers = null;
            _sumParts = null;
            _noOfParts = 1;
        }

        public Int64 Average(List<int> numbers)
        {
            return Average(numbers, 0, numbers.Count);
        }

        public Int64 Average(List<int> numbers, int from, int to)
        {
            Int64 sum = 0;
            for (int i = from; i < to; i++)
            {
                sum = sum + numbers[i];
            }
            return sum / (to - from);
        }

        public Int64 AverageTwoTasks(List<int> numbers)
        {
            // Setup part-variables
            Int64 sumPartA = 0;
            Int64 sumPartB = 0;
            Int64 sumPartC = 0;
            Int64 sumPartD = 0;

            Task taskA = new Task(() => { sumPartA = Average(numbers, 0, numbers.Count / 4); });
            Task taskB = new Task(() => { sumPartB = Average(numbers, numbers.Count / 4, numbers.Count / 2); });
            Task taskC = new Task(() => { sumPartC = Average(numbers, numbers.Count / 2, 3 * numbers.Count / 4); });
            Task taskD = new Task(() => { sumPartD = Average(numbers, 3 * numbers.Count / 4, numbers.Count); });

            taskA.Start();
            taskB.Start();
            taskC.Start();
            taskD.Start();

            Task.WaitAll(taskA, taskB, taskC, taskD);
            

            return (sumPartA + sumPartB + sumPartC + sumPartD) / 4;
        }


        public Int64 SmartAverage(List<int> numbers, int noOfParts)
        {
            _numbers = numbers;
            _noOfParts = noOfParts;
            _sumParts = new List<Int64>();

            // Add counters for each part
            for (int i = 0; i < _noOfParts; i++)
            {
                _sumParts.Add(0);
            }

            // Do the average calculations for each part
            for (int i = 0; i < _noOfParts; i++)
            {
                DoPart(i);
            }

            Parallel.For(0, _noOfParts, DoPart);

            return _sumParts.Sum() / _noOfParts;
        }

        private void DoPart(int i)
        {
            int countPart = _numbers.Count / _noOfParts;
            _sumParts[i] = Average(_numbers, countPart * i, countPart * (i + 1));
        }
    }
}