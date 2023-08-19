WillOccurException();
Action d = One;
d += Two;
var delegates = d.GetInvocationList();
foreach (var @delegate in delegates)
{
    var de = (Action)@delegate;
    try
    {
        de();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception caught");
    }
}

void WillOccurException()
{
    Action d1 = One;
    d1 += Two;
    try
    {
        d1();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception caught");
    }
}

static void One()
{
    Console.WriteLine("One");
    throw new Exception("Error in One");
}

static void Two()
{
    Console.WriteLine($"Two");
}