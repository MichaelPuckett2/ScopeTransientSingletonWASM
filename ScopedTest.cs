namespace ScopeTransientSingletonWASM;

public class ScopedTest
{
    public ScopedTest() => Guid = Guid.NewGuid();
    public Guid Guid { get; }
}
