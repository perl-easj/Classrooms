using System;

namespace ClassroomA
{
    public class Dog : Animal
    {
        private bool _canHunt;

        public Dog(int age, bool canHunt)
            : base(age)
        {
            _canHunt = canHunt;
        }

        public bool CanHunt
        {
            get { return _canHunt; }
        }

        public override void Sound()
        {
            Console.WriteLine("Vov");
        }
    }
}