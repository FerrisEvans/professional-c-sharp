try
{
    Currency balance = new(50, 35);
    Console.WriteLine(balance);
    Console.WriteLine($"{balance}");
    float balance2 = balance;
    Console.WriteLine($"After converting to float, = {balance2}");
    balance = (Currency)balance2;
    Console.WriteLine($"After converting back to Currency, = {balance}");
    Console.WriteLine($"Now attempt to convert out of range value of -$50.50 to a Currency: ");
    checked
    {
        balance = (Currency)(-50.50);
        Console.WriteLine($"Result is {balance}");
    }
    
}
catch (Exception e)
{
    Console.WriteLine($"Exception occured: {e.Message}");
}