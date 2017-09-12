using System;
using System.Collections.Generic;

namespace ClassroomA
{
    public class CarSearcher
    {
        public static bool LicensePlateMatch(Car aCar, string licensePlate)
        {
            return aCar.LicensePlate == licensePlate;
        }

        public static bool PriceMatch(Car aCar, int price)
        {
            return aCar.Price == price;
        }


        // Hvad er "fast" i denne metode?
        // Hvad kan parameteriseres?
        public static T Find<T>(List<T> list, Func<T, bool> matchCondition)
        {
            foreach (T item in list)
            {
                if (matchCondition(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}