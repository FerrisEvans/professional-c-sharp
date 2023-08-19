Func<string, string> oneParam = s => $"change upper case {s.ToUpper()}";
Console.WriteLine(oneParam("test"));

Func<double, double, double> twoParam = (x, y) => x * y;
Console.WriteLine(twoParam(3, 2));

int val = 5;
Func<int, int> f = x => x + val;
Console.WriteLine(f(3)); // 8
val = 7;
Console.WriteLine(f(3)); // 10