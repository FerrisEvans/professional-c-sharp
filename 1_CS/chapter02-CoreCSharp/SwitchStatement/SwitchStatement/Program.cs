void SwitchSample(int x)
{
    switch (x)
    {
        case 1:
            Console.WriteLine(1);
            break;
        case 2:
            Console.WriteLine(2);
            break;
        case 3:
            Console.WriteLine(3);
            break;
        default:
            Console.WriteLine("-----");
            break;
    }
}

void SwitchWithPatternMatching(object o)
{

    switch (o)
    {
        case null:
            Console.WriteLine("const pattern with null");
            break;
        case int i when i > 42:
            Console.WriteLine("type pattern with when and a relational pattern");
            break;
        case int:
            Console.WriteLine("type pattern with an int");
            break;
        case Book b:
            Console.WriteLine($"type pattern with a Book {b?.Title}");
            break;
        default:
            break;
    }
}

class Book
{
    public string? Title { get; set; }
}
