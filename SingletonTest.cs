namespace ScopeTransientSingletonWASM;

public class SingletonTest
{
    public SingletonTest() => Guid = Guid.NewGuid();
    public Guid Guid { get; }
}
