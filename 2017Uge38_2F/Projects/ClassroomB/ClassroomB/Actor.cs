namespace ClassroomB
{
    public class Actor
    {
        private string _name;

        public Actor(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}