// See https://aka.ms/new-console-template for more information
using System;

int x = Math.GetSquareOf(5);
Console.WriteLine($"Square of 5 is {x}");

Math m = new();
m.Value = 30;
Console.WriteLine($"Value field of math variable contains {m.Value}");
Console.WriteLine($"Square of 30 is {m.GetSquare()}");

void AnyNumberOfAtgs(params int[] data)
{
    foreach (var x in data)
    {
        Console.WriteLine(x);
    }
}

AnyNumberOfAtgs();
AnyNumberOfAtgs(1);
AnyNumberOfAtgs(1, 2, 3, 4, 5);


public class Math
{
    public int Value { get; set; }
    public int GetSquare() => Value * Value;
    public static int GetSquareOf(int x) => x * x;
}

