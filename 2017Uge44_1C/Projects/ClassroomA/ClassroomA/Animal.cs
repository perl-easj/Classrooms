namespace ClassroomA
{
    public abstract class Animal
    {
        private int _age;

        protected Animal(int age)
        {
            _age = age;
        }

        public int Age
        {
            get { return _age; }
        }

        public abstract void Sound();
    }
}