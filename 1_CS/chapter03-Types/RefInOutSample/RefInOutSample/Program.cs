// See https://aka.ms/new-console-template for more information

void ChangeAValueType(ref int a)
{
    a = 2;
}
int a = 1;
ChangeAValueType(ref a);
Console.WriteLine($"the value of a changed to {a}");

void ChangingAReferenceByRef(ref SomeData data)
{
    data.Value = 2;
    data = new SomeData { Value = 3 };
}
SomeData data1 = new() { Value = 1 };
ChangingAReferenceByRef(ref data1);
Console.WriteLine($"the new value of data1.Value is: {data1.Value}");


void PassValueByReferenceReadonly(in SomeValue data)
{
    // you cannot change a value, it's a read-only variable!
    // data.Value1 = 4
}

ref SomeValue Max(ref SomeValue x, ref SomeValue y)
{
    int sumX = x.Value1 + x.Value2 + x.Value3 + x.Value4;
    int sumY = y.Value1 + y.Value2 + y.Value3 + y.Value4;

    ref SomeValue result = ref (sumX > sumY) ? ref x : ref y;
    return ref result;
}
SomeValue one = new SomeValue(1, 2, 3, 4);
SomeValue two = new SomeValue(5, 6, 7, 8);

SomeValue bigger1 = Max(ref one, ref two);
ref SomeValue bigger2 = ref Max(ref one, ref two);
ref readonly SomeValue bigger3 = ref Max(ref one, ref two);

ref readonly SomeValue MaxReadonly(in SomeValue x, in SomeValue y)
{
    int sumX = x.Value1 + x.Value2 + x.Value3 + x.Value4;
    int sumY = y.Value1 + y.Value2 + y.Value3 + y.Value4;

    return ref (sumX > sumY) ? ref x : ref y;
}
ref readonly SomeValue bigger4 = ref MaxReadonly(in one, in two);
SomeValue bigger5 = MaxReadonly(in one, in two);

Console.Write("Pleases enter a numver: ");
string? input = Console.ReadLine();
if (int.TryParse(input, out int x))
{
    Console.WriteLine();
    Console.WriteLine($"read an int: {x}");
}

class SomeData
{
    public int Value { get; set; }
}

struct SomeValue
{
    public int Value1 { get; set; }
    public int Value2 { get; set; }
    public int Value3 { get; set; }
    public int Value4 { get; set; }

    public SomeValue(int v1, int v2, int v3, int v4)
    {
        Value1 = v1;
        Value2 = v2;
        Value3 = v3;
        Value4 = v4;
    }
}