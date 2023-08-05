public record Person(string FirstName, string LastName) : IComparable<Person>
{
    public int CompareTo(Person? other)
    {
        int compare = LastName.CompareTo(other?.LastName);
        return compare is 0 ? FirstName.CompareTo(other?.FirstName) : compare;
    }

    public override string ToString() => $"override ToString Person: first name is: {FirstName}, last name is: {LastName}";
}