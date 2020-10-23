namespace DomainLib
{
    public interface ICustomKey<out T>
    {
        T ID { get; }
    }
}