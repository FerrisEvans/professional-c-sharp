public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine($"msg: {message}.");

    void ILogger.Log(Exception ex) => Console.WriteLine($"exception type: {ex.GetType().Name}, message: {ex.Message}");
    
}