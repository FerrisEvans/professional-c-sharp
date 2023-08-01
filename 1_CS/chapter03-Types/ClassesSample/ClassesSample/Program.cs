// See https://aka.ms/new-console-template for more information
Book b1 = new("Professional C#")
{
    No = 2
};

Console.WriteLine($"book's title is {b1.Title} and NO. is {b1.No}");

public class Person
{
    private readonly string _firstName;
    private readonly string _lastName;

    public Person (string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    private int _age1;
    public int Age1
    {
        get
        {
            return _age1;
        }
        set
        {
            _age1 = value;
        }
    }

    private int _age;
    public int Age
    {
        get => _age;
        set => _age = value;
    }

    private string _name;
    public string Name
    {
        get => _name;
        private set => _name = value;
    }

    public string Name1 { get; private set; }

    private readonly string _name2;
    public string Name2
    {
        get => _name2;
    }

    public string Id { get; } = Guid.NewGuid().ToString();
}

public static class PeopleFactory
{
    private static int s_peopleCount;
}

public class Book
{
    public string Title { get; }
    public Book(string title) => Title = title;

    public int No { get; init; }

    public Book(int no)
    {
        No = no;
    }
}