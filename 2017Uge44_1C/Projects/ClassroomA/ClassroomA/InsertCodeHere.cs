// ReSharper disable UnusedVariable

using System;

namespace ClassroomA
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            try
            {
                Cat myCat = new Cat(6, -45);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}