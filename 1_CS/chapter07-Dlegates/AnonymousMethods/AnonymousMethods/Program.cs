string mid = ", middle part,";
Func<string, string> anonDel = delegate(string param)
{
    param += mid;
    param += "and this was added to the string.";
    return param;
};
Console.WriteLine(anonDel("Start of string"));

Func<string, string> lambda = param =>
{
    param += mid;
    param += " and this was added to the string.";
    return param;
};
Console.WriteLine(lambda("Start of string"));