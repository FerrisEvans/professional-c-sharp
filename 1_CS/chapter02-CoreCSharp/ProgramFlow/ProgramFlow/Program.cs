// See https://aka.ms/new-console-template for more information
Console.WriteLine("Type in a string");
string? input = Console.ReadLine();

if (string.IsNullOrEmpty(input))
{
    Console.WriteLine("You typed an empty string.");
}
else if (input?.Length < 5)
{
    Console.WriteLine("The string had lass than 5 characters.");
}
else
{
    Console.WriteLine("Read any other string.");
}

Console.WriteLine("The string was " + input);

