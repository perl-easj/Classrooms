using System;

namespace ClassroomA
{
    public class Cat : Animal
    {
        private double _purrDB;

        public Cat(int age, double purrDb) 
            : base(age)
        {
            if (purrDb < 0)
            {
                throw new ArgumentException();    
            }

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

        public override string ToString()
        {
            return $"This is a Cat of age {Age}, {PurrDb} db purr.";
        }
    }
}