using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ClassroomB
{
    public class AverageCalculator
    {
        public Int64 AverageWithCancel(List<int> numbers, CancellationToken token)
        {
            return AverageWithCancel(numbers, 0, numbers.Count, token);
        }

        public Int64 AverageWithCancel(List<int> numbers, int from, int to, CancellationToken token)
        {
            Int64 sum = 0;

            for (int j = 0; j < 100 && !token.IsCancellationRequested; j++) // artificial delay
            {
                sum = 0;

                for (int i = from; i < to && !token.IsCancellationRequested; i++)
                {
                    sum = sum + numbers[i];
                } 
            }

            if (token.IsCancellationRequested)
            {
                return -1;
            }

            return sum / (to - from);
        }

        public Int64 AverageAsTask(List<int> numbers, CancellationToken token)
        {
            Task<Int64> taskA = new Task<Int64>(() => AverageWithCancel(numbers, 0, numbers.Count, token));
            taskA.Start();
            return taskA.Result;
        }
    }
}