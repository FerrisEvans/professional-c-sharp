// See https://aka.ms/new-console-template for more information
int? n1 = null;

int n2 = -1;

if (n1.HasValue)
{
    n2 = n1.Value;
}

int n3 = 42;
int? n4 = n3;

Console.WriteLine("n1 = " + n1);
Console.WriteLine("n2 = " + n2);
Console.WriteLine("n3 = " + n3);
Console.WriteLine("n4 = " + n4);
