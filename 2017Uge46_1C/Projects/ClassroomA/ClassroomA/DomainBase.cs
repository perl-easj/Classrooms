namespace ClassroomA
{
    public class DomainBase<T>
    {
        private T _key;

        public DomainBase(T key)
        {
            Key = key;
        }

        public T Key
        {
            get { return _key; }
            set { _key = value; }
        }
    }
}