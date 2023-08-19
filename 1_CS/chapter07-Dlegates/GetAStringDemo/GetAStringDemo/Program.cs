int x = 40;
GetAString firstStringMethod = x.ToString;
Console.WriteLine($"String is {firstStringMethod()}");

var balance = new Currency(34, 50);
firstStringMethod = balance.ToString;
Console.WriteLine($"String is {firstStringMethod()}");

firstStringMethod = Currency.GetCurrencyUint;
Console.WriteLine($"String is {firstStringMethod()}");

public delegate string GetAString();