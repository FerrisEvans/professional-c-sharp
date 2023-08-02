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