// 复合赋值运算符
void PrefixAndPostfix()
{
    int x = 5;
    if (++x == 6) Console.WriteLine("This will execute");
    if (x++ == 6) Console.WriteLine($"The value of x is {x}");
}
PrefixAndPostfix();

// 条件运算符
int x = 1;
string s = x + " ";
s += (x == 1 ? "man" : "men");
Console.WriteLine(s);

// checked & unchecked
byte b = 255;
checked
{
    // b++;
}
Console.WriteLine(b);
// b = checked(b + 3);

// is & as
void SomeAction(BaseClass baseClass)
{
    DerivedClass? derivedClass = baseClass as DerivedClass;
    if (derivedClass is not null)
    {
        //可使用 derived class
    }

    if (baseClass is DerivedClass derived)
    {
        // 可使用 derived
    }
}
// sizeof
Console.WriteLine(sizeof(int));

// ??
int? a = null;
int c;
c = a ?? 10;
Console.WriteLine(c);
a = 3;
c = a ?? 10;
Console.WriteLine(c);

// ?.
void ShowPerson(Person? p)
{
    //if (p is null) return;
    string firstName = p?.FirstName;
    int? age = p?.Age;
}

public class P119
{
    private MyClass _val;
    public MyClass Val
    {
        //get => _val ?? (_val = new MyClass());
        get => _val ??= new MyClass();
    }
}

public record Person (string FirstName, int? Age);

// 类不能使用sizeof运算符
public readonly struct Point
{
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y) => (X, Y) = (x, y);
}

public class MyClass
{

}

public class BaseClass
{

}

public class DerivedClass : BaseClass
{

}