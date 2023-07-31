// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

void UsingStringBuilder()
{
    StringBuilder sb = new("the quick");
    sb.Append(' ');
    sb.Append("brown fox jumped over ");
    sb.Append("the lazy dogs 12345678 times");

    string s = sb.ToString();
    Console.WriteLine(s);

}
UsingStringBuilder();


void UsingFormattableString()
{
    int x = 3, y = 4;
    FormattableString s = $"The result of {x} + {y} is {x + y}";
    Console.WriteLine($"format: {s.Format}");

    for (int i = 0; i < s.ArgumentCount; i++)
    {
        Console.WriteLine($"argument: {i}:{s.GetArgument(i)}");
    }
    Console.WriteLine();
}
UsingFormattableString();

void UseStringFormat()
{
    DateTime day = new DateTime(2025, 2, 14);
    Console.WriteLine($"{day:D}");
    Console.WriteLine($"{day:d}");

    int i = 2477;
    Console.WriteLine($"{i:n} {i:e} {i:x} {i:c}");

    double d = 3.1415;
    Console.WriteLine($"{d:###.###}");
    Console.WriteLine($"{d:000.000}");
    Console.WriteLine();

}
UseStringFormat();