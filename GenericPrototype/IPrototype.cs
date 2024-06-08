namespace GenericPrototype;

public interface IPrototype<T> where T : IPrototype<T>
{
    T Copy();
}
