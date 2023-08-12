public enum PersonCompareType
{
    FirstName,
    LastName,
}

public class PersonCompare : IComparer<Person>
{
    private readonly PersonCompareType _compareType;

    public PersonCompare(PersonCompareType type) => _compareType = type;
    
    public int Compare(Person? x, Person? y)
    {
        if (x is null && y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;

        return _compareType switch
        {
            PersonCompareType.FirstName => x.FirstName.CompareTo(y.FirstName),
            PersonCompareType.LastName => x.LastName.CompareTo(y.LastName),
            _ => throw new ArgumentException("unexpected compare type")
        };
    }
}