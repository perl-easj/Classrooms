using System;
using System.Collections.Generic;
// ReSharper disable NotAccessedVariable
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantAssignment

namespace ClassroomA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Car objects og List<Car>

            List<Car> carsInStock = new List<Car>();

            carsInStock.Add(new Car("AB 43 661", 45000));
            carsInStock.Add(new Car("CD 61 965", 80000));
            carsInStock.Add(new Car("EF 80 025", 60000));
            carsInStock.Add(new Car("GH 22 637", 25000));

            #endregion


            #region Car search v1 (direct)

            string searchStr = "EF 80 025";
            Car carMatch = null;
            foreach (var car in carsInStock)
            {
                if (car.LicensePlate == searchStr)
                {
                    carMatch = car;
                }
            }
            Console.WriteLine($"Found this car: {carMatch}");
            Console.WriteLine();

            int searchPrice = 80000;
            foreach (var car in carsInStock)
            {
                if (car.Price == searchPrice)
                {
                    carMatch = car;
                }
            }
            Console.WriteLine($"Found this car: {carMatch}");
            Console.WriteLine();

            #endregion


            #region Car search v2 (CarSearcher)

            searchPrice = 25000;
            foreach (var car in carsInStock)
            {
                if (CarSearcher.PriceMatch(car, searchPrice))
                {
                    carMatch = car;
                }
            }
            Console.WriteLine($"Found this car: {carMatch}");
            Console.WriteLine();

            #endregion


            #region Functions v1 (direct + explicit)

            int a = 7;
            int b = 12;

            Car myCar = new Car("XY 32 105", 125000);

            int resultOfArithmeticExp = a * b;  // (int, int) => int
            bool resultOfLogicExp = a < b; // (int, int) => bool

            resultOfArithmeticExp = Functions.Multiplier(a, b);  // (int, int) => int
            resultOfLogicExp = Functions.SmallerThan(a, b); // (int, int) => bool 

            #endregion


            #region Functions v2 (delegates)

            Func<int, int, int> valueCalculatorFunc = Functions.Multiplier;
            Func<int, int, bool> valueComparerFunc = Functions.SmallerThan;

            Console.WriteLine($"running valueCalculatorFunc on values {a} and {b} gives {valueCalculatorFunc(a, b)}"); // Invokes valueCalculatorFunc
            Console.WriteLine($"running valueComparerFunc on values {a} and {b} gives {valueComparerFunc(a, b)}"); // Invokes valueComparerFunc
            Console.WriteLine();

            valueCalculatorFunc = (x, y) => x + 3 * y;
            valueComparerFunc = (int x, int y) => { return x * 2 < y; };

            Console.WriteLine($"running valueCalculatorFunc on values {a} and {b} gives {valueCalculatorFunc(a, b)}"); // Invokes valueCalculatorFunc
            Console.WriteLine($"running valueComparerFunc on values {a} and {b} gives {valueComparerFunc(a, b)}"); // Invokes valueComparerFunc
            Console.WriteLine();

            Func<Car, bool> carMatchFunc = (Car c) => { return c.LicensePlate == "HHH"; };
            CarSearcher.Find(carsInStock, carMatchFunc);
            #endregion


            #region Car search v3 (delegates)

            searchPrice = 25000;
            carMatch = null;
            Predicate<Car> carMatchPred = (Car c) => { return c.Price == searchPrice; };

            carMatch = carsInStock.Find(carMatchPred); // carMatchPred er parameter!
            Console.WriteLine($"Found this car: {carMatch}");
            Console.WriteLine();

            searchStr = "CD 61 965";
            carMatch = null;
            carMatchFunc = (Car c) => { return c.LicensePlate == searchStr; };

            carMatch = carsInStock.Find(carMatchPred); // carMatchFunc er parameter!
            Console.WriteLine($"Found this car: {carMatch}");
            Console.WriteLine();

            #endregion


            #region Multiple delegates ex1

            Action doStuffFunc = () => { Console.WriteLine("Hello there!"); };
            doStuffFunc += () => { Console.WriteLine("Hejsa!"); };
            doStuffFunc += () => { Console.WriteLine("Guten tag!"); };

            doStuffFunc();

            #endregion


            #region Multiple delegates ex2

            TemperatureMonitor monitor = new TemperatureMonitor();
            GUIClient g1 = new GUIClient("T is now");
            GUIClient g2 = new GUIClient("We're now at");
            GUIClient g3 = new GUIClient("T = ");

            monitor.TemperatureChanged += g1.TemperatureHasChanged;
            monitor.TemperatureChanged += g2.TemperatureHasChanged;
            monitor.TemperatureChanged += g3.TemperatureHasChanged;
            monitor.TemperatureChanged += FunAndGames.WooHoo;


            monitor.Poke();
            monitor.Poke();
            monitor.Poke(); 

            #endregion


            Console.WriteLine("Done - press any key to shut down the app");
            Console.ReadKey();
        }
    }
}
