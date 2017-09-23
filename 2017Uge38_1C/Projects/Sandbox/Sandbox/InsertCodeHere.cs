using System;
// ReSharper disable UnusedVariable
#pragma warning disable 168

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            #region Typer - repetition (navnekonvention, simpel I/O)

            int ageInYears = 49;

            double height = 1.86;

            string fullName = "Per Laursen";

            bool isMarried = false;

            Console.WriteLine($"{fullName} is {ageInYears} years old, is {height} m (Married: {isMarried})");

            #endregion


            #region Aritmetik - repetition

            int a = 12;
            int b = 17;
            int c = a + b;
            int d = 3 * c + (a + b + c);

            Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}");

            #endregion


            #region Logik

            bool areEqual = (a == b);
            bool bLarger = (b >= a);

            int age = 16;
            bool isAdult = (age >= 18);

            bool isTeenager = (age > 12) && (age < 20);

            bool canGetDiscount = (age < 11) || (age >= 65);

            bool mustPayFullPrice = !canGetDiscount;

            #endregion


            #region Funktioner

            double myBMI = BMI(1.87, 88.5);

            bool perIsOverweight = IsOverweight(1.87, 88.5);
            
            Console.WriteLine($"Per is overweight: {perIsOverweight}, (has a BMI of {myBMI:F})"); 

            #endregion

            // The LAST line of code should be ABOVE this line
        }

        #region Eksempler på funktioner
        public double BMI(double height, double weight)
        {
            return (weight / (height * height));
        }

        public bool IsOverweight(double height, double weight)
        {
            return (BMI(height, weight) > 25);
        } 
        #endregion
    }
}