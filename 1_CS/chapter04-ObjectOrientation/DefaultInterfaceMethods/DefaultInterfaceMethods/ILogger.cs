public interface ILogger
{
    void Log(string message);
    public void Log(Exception e) => Log(e.Message);
}