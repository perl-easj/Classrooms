namespace ClassroomA
{
    public class Sleeper
    {
        private bool _asleep;

        public Sleeper()
        {
            _asleep = false;
        }

        public bool Asleep
        {
            get { return _asleep; }
            set { _asleep = value; }
        }
    }
}