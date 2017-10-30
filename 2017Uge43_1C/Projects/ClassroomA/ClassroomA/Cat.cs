using System;

namespace ClassroomA
{
    public class Cat : Animal
    {
        private double _purrDB;

        public Cat(int age, double purrDb) 
            : base(age)
        {
            _purrDB = purrDb;
        }

        public double PurrDb
        {
            get { return _purrDB; }
        }

        public override void Sound()
        {
            Console.WriteLine("Miav");
        }
    }
}