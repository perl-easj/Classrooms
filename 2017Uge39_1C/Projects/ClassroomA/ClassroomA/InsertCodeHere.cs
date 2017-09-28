// ReSharper disable UnusedVariable

using System;

namespace ClassroomA
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            #region Repetition - brug af eksisterende klasse
            
            // Skab et nyt Circle-objekt, og lad variablen
            // c1 referere til objektet
            Circle c1 = new Circle(3, 4, 10);


            // Benyt property Radius (get-delen)
            // INGEN brug af parenteser mår man benytter properties!
            Console.WriteLine($"Radius er {c1.Radius:F}");


            // Benyt property Radius (set-delen)
            c1.Radius = 12;


            // Benyt property Area (get-delen)
            Console.WriteLine($"Areal er {c1.Area:F}");


            // Benyt property Area (set-delen) NIXEN BIXEN!!
            // (fordi kun get-delen af Area er defineret)
            //c1.Area = 12;


            // Kald metoden Move - skal angive to værdier
            // som del af kaldet. Angives indenfor parenteser,
            // adskilt af komma.
            // Værdier kan også være beregnede værdier
            c1.Move(3.6, 8.1);
            c1.Move(c1.X + 15, c1.Y * 3);


            // Kald metoden PrintInformation - ingen parametre
            // HUSK alligevel parenteser EFTER metode-navnet!
            c1.PrintInformation();

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

            #endregion


            #region Test A

            Console.WriteLine("Test A - to INT variable (direkte,direkte)");

            int a = 12;
            int b = 14;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine();

            a = 23;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine();
            Console.ReadKey();

            #endregion


            #region Test B

            Console.WriteLine("Test B - to INT variable (direkte,indirekte)");

            int d = 11;
            int e = d;

            Console.WriteLine($"d = {d}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine();

            d = 34;

            Console.WriteLine($"d = {d}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine();
            Console.ReadKey();


            #endregion


            #region Test C

            Console.WriteLine("Test C - to CIRCLE variable (direkte, direkte)");

            Circle cA = new Circle(2, 4, 8);
            Circle cB = new Circle(3, 5, 9);

            PrintCircleInfo("A", cA);
            PrintCircleInfo("B", cB);
            Console.WriteLine();

            cA.X = 7;

            PrintCircleInfo("A", cA);
            PrintCircleInfo("B", cB);
            Console.WriteLine();
            Console.ReadKey();


            #endregion


            #region Test D

            Console.WriteLine("Test D - to CIRCLE variable (direkte, indirekte)");

            Circle cD = new Circle(10, 12, 14);
            Circle cE = cD;

            PrintCircleInfo("D", cD);
            PrintCircleInfo("E", cE);
            Console.WriteLine();

            cD.X = 20;

            PrintCircleInfo("D", cD);
            PrintCircleInfo("E", cE);
            Console.WriteLine();
            Console.ReadKey();

            #endregion
        }

        private void PrintCircleInfo(string id, Circle c)
        {
            Console.WriteLine($"{id}: ({c.X},{c.Y}) radius {c.Radius} (areal {c.Area:F})");
        }
    }
}