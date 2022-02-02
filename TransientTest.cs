namespace ScopeTransientSingletonWASM;
public class TransientTest
{
    public TransientTest() => Guid = Guid.NewGuid();
    public Guid Guid { get; }
}
