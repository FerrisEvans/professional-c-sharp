// See https://aka.ms/new-console-template for more information

void ColorSamples()
{
    Color c1 = Color.Red;
    Console.WriteLine(c1);
}
ColorSamples();

Color1 c2 = (Color1)2;
short number = (short)c2;
Console.WriteLine(c2);
Console.WriteLine(number);

DaysOfWeek monAndWeb = DaysOfWeek.Monday | DaysOfWeek.Wednesday;
Console.WriteLine(monAndWeb);

if (Enum.TryParse<Color>("Red", out Color red)) Console.WriteLine($"successfully parsed {red}");

foreach (var color in Enum.GetValues(typeof(Color))) Console.WriteLine(color);

foreach (short color1 in Enum.GetValues(typeof(Color1))) Console.WriteLine(color1);

public enum Color
{
    Red,
    Green,
    Blue,
}

public enum Color1 : short
{
    Red = 1,
    Green = 2,
    Blue = 3
}