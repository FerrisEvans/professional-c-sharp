// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

class GenericMethods
{
    public static void Swap<T>(ref T x, ref T y)
    {
        // (x, y) = (y, x);
        T t;
        t = x;
        x = y;
        y = t;
    }
}