using System;

namespace ClassroomA
{
    public class Duck : Sleeper, IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Quack!");
        }

        public void Eat()
        {
            Console.WriteLine("Nom nom...");
        }

        public bool Sleeping
        {
            get { return Asleep; }
        }
    }
}