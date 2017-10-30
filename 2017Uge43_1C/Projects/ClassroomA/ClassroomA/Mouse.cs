using System;

namespace ClassroomA
{
    public class Mouse : Sleeper, IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Squeak!");
        }

        public void Eat()
        {
            Console.WriteLine("Nibble nibble...");
        }

        public bool Sleeping
        {
            get { return Asleep; }
        }
    }
}