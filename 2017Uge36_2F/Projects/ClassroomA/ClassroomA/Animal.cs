using System;

namespace ClassroomA
{
    public class Animal : IComparable<Animal>
    {
        private string _name;
        private int _weight;

        public Animal(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Weight
        {
            get { return _weight; }
        }

        public int CompareTo(Animal other)
        {
            if (Weight < other.Weight) { return -1; }

            if (Weight > other.Weight) { return 1; }

            return 0;
        }
    }
}