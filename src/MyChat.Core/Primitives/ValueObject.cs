namespace MyChat.Core.Primitives;

public abstract class ValueObject
{
    public abstract IEnumerable<object?> GetAtomicValues();

    public override bool Equals(object? obj)
    {
        return obj is ValueObject other && AreValuesEqual(other);
    }

    public override int GetHashCode()
    {
        return GetAtomicValues()
            .Aggregate(
                default(int),
                HashCode.Combine);
    }

    private bool AreValuesEqual(ValueObject other)
    {
        return GetAtomicValues().SequenceEqual(other.GetAtomicValues());
    }
}
