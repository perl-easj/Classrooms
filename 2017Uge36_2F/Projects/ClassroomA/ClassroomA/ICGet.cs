namespace ClassroomA
{
    public interface ICGet<out T>
    {
        T Get();
    }
}