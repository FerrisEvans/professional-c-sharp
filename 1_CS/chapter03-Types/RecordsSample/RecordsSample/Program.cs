// See https://aka.ms/new-console-template for more information

Book2 b2 = new("Professional C#", "Wrox Press");
Console.WriteLine(b2);

Book1 b1a = new("Professional C#")
{
    Publisher = "Wrox Press"
};

Book1 b1b = new("Professional C#", "Wrox Press");

if (!object.ReferenceEquals(b1a, b1b)) Console.WriteLine("Two different references for equal records");

if (b1a == b1b) Console.WriteLine("Both records have the same values");

var newB1b = b1b with
{
    Title = "new Title from b1b"
};

Console.WriteLine(newB1b);

public record Book1
{
    public Book1(string title) => Title = title;

    public Book1(string title, string publisher)
    {
        Title = title;
        Publisher = publisher;
    }

    public string Title { get; init; } = string.Empty;
    public string Publisher { get; init; } = string.Empty;
}

public record Book2(string Title, string Publisher);