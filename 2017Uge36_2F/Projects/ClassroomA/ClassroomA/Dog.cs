namespace ClassroomA
{
    public class Dog : Animal
    {
        private string _race;

        public Dog(string name, int weight, string race) 
            : base(name, weight)
        {
            _race = race;
        }

        public string Race
        {
            get { return _race; }
        }

        public override string ToString()
        {
            return $"A dog named {Name}, {Weight} kg";
        }
    }
}