// See https://aka.ms/new-console-template for more information
AStruct x1 = new() { A = 1 };
AStruct x2 = x1;
x2.A = 2;
Console.WriteLine($"original didn't change with a struct: {x1.A}");

AClass y1 = new() { A = 1 };
AClass y2 = y1;
y2.A = 2;
Console.WriteLine($"original changed with a class: {y1.A}");

ARecord r1 = new() { A = 1 };
ARecord r2 = r1;
r2.A = 2;
Console.WriteLine($"original change with a record: {r1.A}");

var t1 = (Number: 1, String: "a");
var t2 = t1;
t2.Number = 2;
t2.String = "b";
Console.WriteLine($"original didn't change with a tuple: {t1.Number}, {t1.String}");


public record ARecord
{
    public int A;
}

public struct AStruct
{
    public int A;
}

public class AClass
{
    public int A;
}