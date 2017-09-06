namespace ClassroomA
{
    public interface ICSet<in T>
    {
        void Set(T t);
    }
}