Action<double> operation1 = MathOperations.MultiplyByTwo;
Action<double> operation2 = MathOperations.Square;
Action<double> operations = operation1 + operation2;

ProcessAndDisplayNumber(operations, 2.0);
ProcessAndDisplayNumber(operations, 7.94);
ProcessAndDisplayNumber(operations, 1.414);

static void ProcessAndDisplayNumber(Action<double> action, double value)
{
    Console.WriteLine($"ProcessAndDisplayNumber called with value = {value}");
    action(value);
    Console.WriteLine();
}