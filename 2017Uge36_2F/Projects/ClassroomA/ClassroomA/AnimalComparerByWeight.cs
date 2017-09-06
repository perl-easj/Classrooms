using System;
using System.Collections.Generic;

namespace ClassroomA
{
    public class AnimalComparerByWeight : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Really...??");
            }

            if (x.Weight < y.Weight) { return -1; }

            if (x.Weight > y.Weight) { return 1; }

            return 0;
        }
    }
}