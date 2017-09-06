namespace ClassroomA
{
    public class Cat : Animal
    {
        public bool _isNeutered;

        public Cat(string name, int weight) 
            : base(name, weight)
        {
            _isNeutered = false;
        }

        public bool IsNeutered
        {
            get { return _isNeutered; }
            set { _isNeutered = value; }
        }

        public override string ToString()
        {
            return $"A cat named {Name}, {Weight} kg";
        }
    }
}